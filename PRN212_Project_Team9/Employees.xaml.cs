
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
using System.Windows.Shapes;

namespace PRN212_Project_Team9
{
    /// <summary>
    /// Interaction logic for Employees.xaml
    /// </summary>
    public partial class Employees : Window
    {
        //SalesManagementDbContext _con = new SalesManagementDbContext();
        public Employees()
        {
            InitializeComponent();


        }

        private void OrderForCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderForCustomer orderForCustomer = new OrderForCustomer();
            orderForCustomer.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Supplierforproduct_Click(object sender, RoutedEventArgs e)
        {
            Supplierforproduct supplierforproduct = new Supplierforproduct();
            supplierforproduct.Show();
        }

        private void Discount_Click_1(object sender, RoutedEventArgs e)
        {
            Discounts discounts = new Discounts();
            discounts.Show();
        }
    }
}
