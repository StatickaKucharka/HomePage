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

        private List<Recipe> recipes = new List<Recipe>();
        public List<Recipe> Recipes { get { return this.recipes; } set { this.recipes = value; } }
        
        
        
        public LandingPage()
        {

            
            InitializeComponent();
            this.DataContext = this;
            AddRecipe(new Recipe("recept1", "/Obrazky/recepty/recept1.jpg"));
            AddRecipe(new Recipe("recept2", "/Obrazky/recepty/recept2.jpg"));
            AddRecipe(new Recipe("recept3", "/Obrazky/recepty/recept3.jpg"));
            AddRecipe(new Recipe("recept4", "/Obrazky/recepty/recept4.jpg"));
            AddRecipe(new Recipe("recept5", "/Obrazky/recepty/recept5.jpg"));
            AddRecipe(new Recipe("recept6", "/Obrazky/recepty/recept6.jpg"));
            AddRecipe(new Recipe("recept7", "/Obrazky/recepty/recept7.jpg"));
            AddRecipe(new Recipe("recept8", "/Obrazky/recepty/recept8.jpg"));
            AddRecipe(new Recipe("recept9", "/Obrazky/recepty/recept9.jpg"));
            AddRecipe(new Recipe("recept10", "/Obrazky/recepty/recept10.jpg"));
            AddRecipe(new Recipe("recept11", "/Obrazky/recepty/recept11.jpg"));
            AddRecipe(new Recipe("recept12", "/Obrazky/recepty/recept12.jpg"));
            

            if (Recipes.Count > 0)
            {
                ListViewRecipes.ItemsSource = Recipes;
            }
            
            
        }
        public void AddRecipe(Recipe recept)
        {
            recipes.Add(recept);
            
        }
        public List<Recipe> GetRecipes()
        {
            return Recipes;   
        }

       
            
        
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new System.Uri("/strany/Recepticky.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
