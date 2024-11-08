using Microsoft.EntityFrameworkCore.Diagnostics;
using PRN212_Project_Team9.Models;
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
    /// Interaction logic for OrderForCustomer.xaml
    /// </summary>
    public partial class OrderForCustomer : Window
    {


        SalesManagementDbContext _con = new SalesManagementDbContext();

        public OrderForCustomer()
        {
            InitializeComponent();
            LoadData();
        }


        private void ProductSelect_ProductSelected(string productData)
        {
            tbxIdProduct.Text = AppMemory.IdProduct.ToString();
            tbxNameProduct.Text = AppMemory.NameProduct.ToString();
            tbxTotalPrice.Text = AppMemory.TotalPrice.ToString();
            tbxQuantityProduct.Text = AppMemory.QuantityProduct.ToString();
        }



        private void LoadData()
        {

            List<string> stringType = new List<string>()
            {    "Id" , "Name" , "Phone"    };

            List<string> stringDateOrder = new List<string>()
            {

            };

            TypeSearch.ItemsSource = stringType.ToList();
            ListCustomer.ItemsSource = _con.Customers.Select(x => new
            {
                x.CustomerId,
                x.CustomerName,
                x.PhoneNumber
            }).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TypeSearch.Text.Equals("Id"))
            {
                int getId;
                if (int.TryParse(InputSearch.Text, out getId))
                {
                    ListCustomer.ItemsSource = _con.Customers.Where(x => x.CustomerId == getId).Select(x => new
                    {
                        x.CustomerId,
                        x.CustomerName,
                        x.PhoneNumber
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Hãy nhập số để tìm kiếm");
                }

            } 
            else if (TypeSearch.Text.Equals("Name"))
            {
                ListCustomer.ItemsSource = _con.Customers.Where(x => x.CustomerName.ToLower().Contains(InputSearch.Text.ToLower())).Select(x => new
                {
                    x.CustomerId,
                    x.CustomerName,
                    x.PhoneNumber
                }).ToList();
            } 
            else if (TypeSearch.Text.Equals("Phone"))
            {
                ListCustomer.ItemsSource = _con.Customers.Where(x => x.PhoneNumber.Equals(InputSearch.Text)).Select(x => new
                {
                    x.CustomerId,
                    x.CustomerName,
                    x.PhoneNumber
                }).ToList();
            }
            else
            {
                MessageBox.Show("Chưa chọn kiểu tìm kiếm");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            // Tạo instance của ProductSelect
            ProductSelect productSelect = new ProductSelect();

            // Đăng ký Event để nhận dữ liệu khi sản phẩm được chọn
            productSelect.ProductSelected += ProductSelect_ProductSelected;
            productSelect.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void OrderSelected_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
    }
}
