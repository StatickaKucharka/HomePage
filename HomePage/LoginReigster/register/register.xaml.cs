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
            User sUser = new User(txtUsername.Text, txtPassword.Password, txtEmail.Text);
            
            

            if (txtEmail.Text.Contains("@gmail.com")) {
                AddUser(sUser);
                if (users.Count != 0)
                {
                    MessageBox.Show("You successfully registered");
                }
                else
                {
                    MessageBox.Show("registration failed");
                }
                
            }
            else
            {
                MessageBox.Show("input valid email address");
            }
            
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
    }
}

