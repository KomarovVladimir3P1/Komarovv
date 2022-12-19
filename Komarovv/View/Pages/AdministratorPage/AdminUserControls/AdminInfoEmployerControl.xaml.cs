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
    /// Логика взаимодействия для AdminInfoEmployerControl.xaml
    /// </summary>
    public partial class AdminInfoEmployerControl : UserControl
    {
        public AdminInfoEmployerControl()
        {
            InitializeComponent();
            DataEmployerInfo.ItemsSource = FrameNavigate.DB.Employers.OrderBy(w => w.FIO).ToList();
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idEmployer = (DataEmployerInfo.SelectedItem as Employer).EmployerID;
            var result = MessageBox.Show("Хотите удалить компанию?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) 
            {
                Employer employer=(from w in FrameNavigate.DB.Employers where w.EmployerID==idEmployer select w).SingleOrDefault();
                FrameNavigate.DB.Employers.Remove(employer);
                FrameNavigate.DB.SaveChanges();
                DataEmployerInfo.ItemsSource=FrameNavigate.DB.Employers.OrderBy(w=>w.FIO).ToList();
            }
        }
    }
}
