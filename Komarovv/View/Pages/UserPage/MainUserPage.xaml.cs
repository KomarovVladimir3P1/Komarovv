using Komarovv.Core;
using Komarovv.View.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        private async void BtnZakaz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrameNavigate.DB.Requests.Add(new Model.Request
                {
                    UserID = Core.Authorization.AuthorizedUser.UserID,
                    Hours = TbZakaz.Text,
                    CarID = 1
                    
                });

                await FrameNavigate.DB.SaveChangesAsync();

                MessageBox.Show("Запрос об аренде отправлен на рассмотрение", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private async void BtnZakaz1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrameNavigate.DB.Requests.Add(new Model.Request
                {
                    UserID = Core.Authorization.AuthorizedUser.UserID,
                    Hours = TbZakaz1.Text,
                    CarID = 2
                });

                await FrameNavigate.DB.SaveChangesAsync();

                MessageBox.Show("Запрос об аренде отправлен на рассмотрение", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private async void BtnZakaz2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrameNavigate.DB.Requests.Add(new Model.Request
                {

                    UserID = Core.Authorization.AuthorizedUser.UserID,
                    Hours = TbZakaz2.Text,
                    CarID = 3
                });

                await FrameNavigate.DB.SaveChangesAsync();

                MessageBox.Show("Запрос об аренде отправлен на рассмотрение", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
