using SalonKrasoti.HelperCase;
using SalonKrasoti.MainPages.PageAdmin;
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

namespace SalonKrasoti.MainPages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoAdmin_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.frameNavigate.Navigate(new PageSignAdmin());
        }

        private void GoDefault_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.frameNavigate.Navigate(new PageDefault()) ;
        }
    }
}
