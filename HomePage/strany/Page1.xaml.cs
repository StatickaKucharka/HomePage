using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CestaKObrazku_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            
            LandingPage achh = new LandingPage();
            MessageBoxResult result = MessageBox.Show("Are you sure you want to add recipe?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes) { 
                
                achh.AddRecipeToList(new Recipe(TBXNadpis.Text, CestaKObrazku.Text));
            }
            
            
            
        }
    }
}
