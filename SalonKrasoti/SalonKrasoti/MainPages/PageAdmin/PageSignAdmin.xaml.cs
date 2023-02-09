using SalonKrasoti.HelperCase;
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

namespace SalonKrasoti.MainPages.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageSignAdmin.xaml
    /// </summary>
    public partial class PageSignAdmin : Page
    {
        public PageSignAdmin()
        {
            InitializeComponent();
        }

        private void BtnSigh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxbPass.Password == "0000")
                {
                     FrameNavigate.frameNavigate.Navigate(new PageAdminTable());
                }
                else
                {
                    MessageBox.Show("Введенные данные неверны. Повторите попытку", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
