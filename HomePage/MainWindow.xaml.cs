using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace HomePage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*string connectionString = "SERVER=localhost3306;DATABASE=OurDatabase;UID=root;PASSWORD=Lukas230920051508;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("select * from test_users", connection);
            connection.Open();
            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());
            connection.Close();
            dtGrid.DataContext = dt;*/
            
        }
        
    }
}
