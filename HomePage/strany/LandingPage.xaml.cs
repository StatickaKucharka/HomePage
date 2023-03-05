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
    /// Interaction logic for LandingPage.xaml
    /// </summary>
    public partial class LandingPage : Page
    {
        Page1 skusam = new Page1();
        List<Recipe> recipes = new List<Recipe>();
            
        public LandingPage()
        {
            
            
            InitializeComponent();
            var recepty = GetRecipes();
            if (recipes.Count > 0)
            {
                ListViewRecipes.ItemsSource = GetRecipes();
            }
        }
        public List<Recipe> GetRecipes()
        {
            return recipes;
            {
                
            };
        }
        
       
        public void AddRecipeToList(Recipe recept)
        {
            recipes.Add(recept); 
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new System.Uri("/strany/Recepticky.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
