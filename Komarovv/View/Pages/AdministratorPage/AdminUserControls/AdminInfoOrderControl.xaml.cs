using Komarovv.Core;
using Komarovv.Model;
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

namespace Komarovv.View.Pages.AdministratorPage.AdminUserControls
{
    /// <summary>
    /// Логика взаимодействия для AdminInfoOrderControl.xaml
    /// </summary>
    public partial class AdminInfoOrderControl : UserControl
    {
        public AdminInfoOrderControl()
        {
            InitializeComponent();
            DataOrderInfo.ItemsSource = FrameNavigate.DB.OrderBoards.OrderBy(u => u.OrderTitle).ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idOrders = (DataOrderInfo.SelectedItem as OrderBoard).OrderBoardID;
            var result = MessageBox.Show("Хотите удалить заказ?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                OrderBoard order = (from u in FrameNavigate.DB.OrderBoards where u.OrderBoardID == idOrders select u).SingleOrDefault();
                FrameNavigate.DB.OrderBoards.Remove(order);
                FrameNavigate.DB.SaveChanges();
                DataOrderInfo.ItemsSource = FrameNavigate.DB.Users.OrderBy(u => u.FIO).ToList();
            }
        }
    }
}
