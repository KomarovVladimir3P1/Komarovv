using Komarovv.Core;
using Komarovv.View.Pages.LoginPage;
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

namespace Komarovv.View.Pages.UserPage
{
    /// <summary>
    /// Логика взаимодействия для MainUserPage.xaml
    /// </summary>
    public partial class MainUserPage : Page
    {
        public MainUserPage()
        {
            InitializeComponent();

            DataOrderInfo.ItemsSource = FrameNavigate.DB.OrderBoards.OrderBy(f => f.OrderTitle).ToList();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заявка отправлена на рассмотрение модерации",
                            "Системное сообщение",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }
    }
}
