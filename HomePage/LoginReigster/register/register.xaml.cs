using HomePage.LoginReigster.login;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace HomePage.LoginReigster.register
{
    /// <summary>
    /// Interaction logic for register.xaml
    /// </summary>
    public partial class register : Window
    {
        private List<User> users = new List<User>();
        public List<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }

        public register()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

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
                if (Count == 0)
                {
                    User user = new User()
                    {
                        UserName = txtUsername.Text,
                        Password = txtPassword.Password,
                        Email = txtEmail.Text
                    };
                    users.Add(user);

                    

                    // create a SQL query to insert a new recipe
                    string query1 = "INSERT INTO users(userName, userPassword, email) VALUES (@userName, @userPassword, @email)";
                    MySqlCommand command1 = new MySqlCommand(query1, connection);

                    // add parameters to the query

                    command1.Parameters.AddWithValue("@userName", txtUsername.Text);
                    command1.Parameters.AddWithValue("@userPassword", txtPassword.Password);
                    command1.Parameters.AddWithValue("@email", txtEmail.Text);

                    // open the connection and execute the query
                    
                    int rowsAffected1 = command1.ExecuteNonQuery();
                    MessageBox.Show("cg to your registration");


                }
                else
                {
                    MessageBox.Show("meno už existuje");
                }
                connection.Close();

                
                

                
            }
            
            
        }
        



    }
}

