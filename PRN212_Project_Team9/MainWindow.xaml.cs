
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PRN212_Project_Team9.Models;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRN212_Project_Team9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SalesManagementDbContext _con = new SalesManagementDbContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<string> data = new List<string>()
            {
                "Employee", "Customer"
            };

            posi.ItemsSource = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (posi.Text.Equals("Employee"))
            {
                var data = _con.Employees.FirstOrDefault(x => x.Account.Equals(acc.Text) && x.Password.Equals(pass.Password));

                if (data != null && data.PositionId == 1)
                {
                    MemoryApp.Id = data.EmployeeId;
                    Admin adminWindow = new Admin();
                    adminWindow.Show();
                }
                else if(data != null && data.PositionId == 2)
                {
                    MemoryApp.Id = data.EmployeeId;
                    Employees employeeWindow = new Employees();
                    employeeWindow.Show();
                }
                else
                {
                    MessageBox.Show("Ko có tài khoản");
                }
            }
            else if (posi.Text.Equals("Customer"))
            {
                var data = _con.Customers.FirstOrDefault(x => x.Account.Equals(acc.Text) && x.Password.Equals(pass.Password));

                if (data != null)
                {
                    MemoryApp.Id = data.CustomerId;
                    Customer customerWindow = new Customer();
                    customerWindow.Show();
                    
                }
                else
                {
                    MessageBox.Show("Ko có tài khoản");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn vị trí");
            }
        }
    }
}