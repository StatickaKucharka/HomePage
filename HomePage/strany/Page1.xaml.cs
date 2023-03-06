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
        LandingPage ach = new LandingPage();

        public Page1()
        {
            InitializeComponent();
            

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Recipe recept = new Recipe(TBXNadpis.Text, CestaKObrazku.Text);
            this.DataContext = recept;
            ach.AddRecipe(recept);
            
            NavigateToPage2();

        }
       

        private void NavigateToPage2()
        {
            if (ach == null)
            {
                ach = new LandingPage();
            }

            NavigationService.Navigate(ach);
        }
    }
}

