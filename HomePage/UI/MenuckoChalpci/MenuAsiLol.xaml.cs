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

namespace HomePage.UI.MenuckoChalpci
{
    /// <summary>
    /// Interaction logic for MenuAsiLol.xaml
    /// </summary>
    public partial class MenuAsiLol : UserControl
    {
        public MenuAsiLol()
        {
            InitializeComponent();

        }


        private void TreeViewItem_MouseUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new System.Uri("/strany/Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Tutorial_MouseUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new System.Uri("/strany/Tutorialyxaml.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Kucharky_MouseUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new System.Uri("/strany/Kucharky.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
