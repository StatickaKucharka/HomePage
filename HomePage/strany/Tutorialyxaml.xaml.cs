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
    /// Interaction logic for Tutorialyxaml.xaml
    /// </summary>
    public partial class Tutorialyxaml : Page
    {
        public Tutorialyxaml()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            video.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            video.Pause();
        }
    }
}
