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
            /*var recipes = GetRecipes();
            if(recipes.Count > 0)
            {
                ListViewRecipes.ItemsSource = recipes;
            }*/
        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
        /*private List<Recipe> GetRecipes()
{
   return new List<Recipe>()
   {
       new Recipe("Recipe 1", "Obrazky/recepty/recept1.jpg"),
       new Recipe("Recipe 2", "Obrazky/recepty/recept2.jpg"),
       new Recipe("Recipe 3", "Obrazky/recepty/recept3.jpg"),
       new Recipe("Recipe 4", "Obrazky/recepty/recept4.jpg"),
       new Recipe("Recipe 5", "Obrazky/recepty/recept5.jpg"),
       new Recipe("Recipe 6", "Obrazky/recepty/recept6.jpg"),
       new Recipe("Recipe 7", "Obrazky/recepty/recept7.jpg"),
       new Recipe("Recipe 8", "Obrazky/recepty/recept8.jpg"),
       new Recipe("Recipe 9", "Obrazky/recepty/recept9.jpg"),
       new Recipe("Recipe 10", "Obrazky/recepty/recept10.jpg"),
       new Recipe("Recipe 11", "Obrazky/recepty/recept11.jpg"),
       new Recipe("Recipe 12", "Obrazky/recepty/recept12.jpg"),
       new Recipe("Recipe 13", "Obrazky/recepty/recept13.jpg"),

   };
}

private void Border_MouseDown(object sender, MouseButtonEventArgs e)
{

}*/

    }
}
