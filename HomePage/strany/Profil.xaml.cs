using HomePage.LoginReigster.login;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for Profil.xaml
    /// </summary>
    public partial class Profil : Page
    {

        string connectionString = "server=localhost;UID=root;password=Lukas230920051508;database=kucharka;";
        public Profil()
        {
            InitializeComponent();
            this.DataContext = UserManager.CurrentUser;
            SetDataContext();

        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == true)
            {
                ImageViewer1.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                UserManager.CurrentUser.Profilovka = ImageViewer1.Source.ToString();


                MySqlConnection connection = new MySqlConnection(connectionString);

                // create a SQL query to insert a new recipe
                string query = "Update users set profilovka = @profilovka WHERE userName = @userName";
                MySqlCommand command = new MySqlCommand(query, connection);

                // add parameters to the query

                command.Parameters.AddWithValue("@profilovka", UserManager.CurrentUser.Profilovka);
                command.Parameters.AddWithValue("@userName", UserManager.CurrentUser.UserName);

                // open the connection and execute the query
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();


            }
        }




        private void Browse_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void SetDataContext()
        {

            MySqlConnection connection = new MySqlConnection(connectionString);

            // create a SQL query to insert a new recipe
            string query1 = "select profilovka from users WHERE userName = @userName";
            MySqlCommand command1 = new MySqlCommand(query1, connection);

            // add parameters to the query


            command1.Parameters.AddWithValue("@userName", UserManager.CurrentUser.UserName);
            connection.Open();
            MySqlDataReader reader = command1.ExecuteReader();

            // open the connection and execute the query

            if (!reader.HasRows)
            {
                Console.WriteLine("No rows returned by query");
            }

            else
            {
                while (reader.Read())
                {
                    UserManager.CurrentUser.Profilovka = reader["profilovka"].ToString();
                    ImageViewer1.DataContext = UserManager.CurrentUser;
                }


            }
        }
    }
}
