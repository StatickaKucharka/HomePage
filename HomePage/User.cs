using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage
{
    public class User
    {
        private List<User> users = new List<User>();
        public List<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }
        private string userName;
        private string password;
        private string email;
        public string UserName { get { return userName; } set { userName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public User() { }
        public User(string userName, string password, string email)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
        }
    }
}
