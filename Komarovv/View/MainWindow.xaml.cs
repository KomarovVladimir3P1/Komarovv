using Komarovv.Core;
using Komarovv.View.Pages.LoginPage;
using Komarovv.Model;
using Komarovv.View.Pages.UserPage;
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
using Komarovv.View.Pages;

namespace Komarovv
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameNavigate.FrameObject = MainWindowFrame;
            FrameNavigate.DB = new DaEntities8();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Navigate(new MainWindowLoginPage());
        }

        private void BtnContacts_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Navigate(new Contacts());
        }
    }
}
