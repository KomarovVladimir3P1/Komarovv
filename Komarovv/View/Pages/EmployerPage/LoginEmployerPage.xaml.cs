using Komarovv.Core;
using Komarovv.Model;
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

namespace Komarovv.View.Pages.EmployerPage
{
    /// <summary>
    /// Логика взаимодействия для LoginEmployerPage.xaml
    /// </summary>
    public partial class LoginEmployerPage : Page
    {
        public LoginEmployerPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employer userModel = FrameNavigate.DB.Employers.FirstOrDefault(u => u.EmployerMail == TBLogin.Text && u.EmployerPhone == PBPassword.Password);

                if (userModel == null)
                {
                    MessageBox.Show("Ошибка данных",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    FrameNavigate.FrameObject.Navigate(new DetailEmployerPage());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                        "Системная ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }
    }
}
