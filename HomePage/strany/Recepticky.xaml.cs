using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    /// Interaction logic for Recepticky.xaml
    /// </summary>
    public partial class Recepticky : Page
    {
        
        public Recepticky()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "server=localhost;UID=root;password=Lukas230920051508;database=kucharka;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // create a SQL query to delete the recipe by name
            string query = "DELETE FROM recepty WHERE nadpis=@Name";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", rNadpis.Text);

            // open the connection and execute the query
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();

            // check if the delete was successful
            if (rowsAffected > 0)
            {
                // show a success message
                MessageBox.Show("Recipe deleted successfully.");
            }
            else
            {
                // show an error message
                MessageBox.Show("Recipe not found.");
            }

            // close the connection
            connection.Close();

            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new System.Uri("/strany/LandingPage.xaml", UriKind.RelativeOrAbsolute));

        }
    }
}
