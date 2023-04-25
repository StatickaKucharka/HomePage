using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Annotations;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomePage.strany
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        LandingPage ourLanidngPage = new LandingPage();
        Recepticky sss = new Recepticky();

        public Page1()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Recipe recept = new Recipe(TBXNadpis.Text, CestaKObrazku.Text, Postup.Text, Ingrediencie.Text);
            this.DataContext = recept;
            ourLanidngPage.AddRecipe(recept);
            NavigateToPage2();
            string connectionString = "server=localhost;UID=root;password=Lukas230920051508;database=kucharka;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // create a SQL query to insert a new recipe
            string query = "INSERT INTO recepty (nadpis, ingrediencie, postup, adresaObrazku) VALUES (@nadpis, @ingrediencie, @postup, @adresaObrazku)";
            MySqlCommand command = new MySqlCommand(query, connection);

            // add parameters to the query
            command.Parameters.AddWithValue("@nadpis", TBXNadpis.Text);
            command.Parameters.AddWithValue("@ingrediencie", Ingrediencie.Text);
            command.Parameters.AddWithValue("@postup", Postup.Text);
            command.Parameters.AddWithValue("@adresaObrazku", CestaKObrazku.Text);

            // open the connection and execute the query
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            // check if the query was successful
            if (rowsAffected > 0)
            {
                MessageBox.Show("Recipe added successfully!");
            }
            else
            {
                MessageBox.Show("Error adding recipe.");
            }
        }


        private void NavigateToPage2()
        {
            if (ourLanidngPage == null)
            {
                ourLanidngPage = new LandingPage();
            }

            NavigationService.Navigate(ourLanidngPage);
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Append the new text to the existing text, including any new line characters
            Ingrediencie.Text += e.Text;

            // Mark the event as handled to prevent the default behavior of the textbox
            e.Handled = true;
        }

    }
}