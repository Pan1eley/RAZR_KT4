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

namespace kt_4
{
    /// <summary>
    /// Логика взаимодействия для AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public AccountWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            SizeToContent = SizeToContent.Manual;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow(); 
            newWindow.Show(); 
            Close();
        }

        private void EmployeesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            EmployeesWindow employeesWindow = new EmployeesWindow();
            employeesWindow.Show();
        }

        private void EquipmentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            EquipmentWindow equipmentWindow = new EquipmentWindow();
            equipmentWindow.Show();
        }

        private void BillingMenuItem_Click(object sender, RoutedEventArgs e)
        {
            BillingWindow billingWindow = new BillingWindow();
            billingWindow.Show();
        }

        private void ContractsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ContractsWindow contractsWindow = new ContractsWindow();
            contractsWindow.Show();
        }

        private void RequestMenuItem_Click(object sender, RoutedEventArgs e)
        {
            RequestWindow requestWindow = new RequestWindow();
            requestWindow.Show();
        }

    

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
