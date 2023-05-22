using HomePage.LoginReigster.register;
using HomePage.strany;
using MySql.Data.MySqlClient;
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

namespace HomePage.LoginReigster.login
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            
            string connectionString = "server=localhost;UID=root;password=Lukas230920051508;database=kucharka;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // create a SQL query to insert a new recipe
            string query = "SELECT * from users where userName = @userName and userPassword = @userPassword";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userName", txtUsername.Text);
            command.Parameters.AddWithValue("@userPassword", txtPassword.Password);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            int Count = Convert.ToInt32(command.ExecuteScalar());
            if (Count > 0)
            {
                MainWindow dashborad = new MainWindow();
                this.Close();
                dashborad.Show();


            }
            else
            {
                MessageBox.Show("zle meno alebo heslo ty dilino");
            }
            connection.Close();
            
            

        }
    }
}
