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
            ProductSelect productSelect = new ProductSelect();
            productSelect.ProductSelected += ProductSelect_ProductSelected;
            productSelect.ShowDialog();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void OrderSelected_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            DateTime? selectedDateTime = OrderSelected.Items[OrderSelected.SelectedIndex] as DateTime?;

            DateTime dateTime = DateTime.Now;

            if (selectedDateTime != null)
            {
                Order? myOrder = _con.Orders.FirstOrDefault(x => x.OrderDate == selectedDateTime && x.CustomerId == Int32.Parse(tbxIdCustomer.Text));

                if (myOrder != null)
                {
                    OrderDetail.ItemsSource = _con.OrderDetails.Where(x => x.OrderId == myOrder.OrderId).ToList();
                }


                
            }
        }


        private void ListCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dynamic customerSelect = ListCustomer.SelectedItem as dynamic;
            if (customerSelect != null)
            {
                tbxIdCustomer.Text = customerSelect.CustomerId.ToString();
                tbxNameCustomer.Text = customerSelect.CustomerName;
                tbxPhoneCustomer.Text = customerSelect.PhoneNumber;

                List<DateTime?> TimeOrder = new List<DateTime?>() { DateTime.Now };
                TimeOrder.AddRange(_con.Orders.Where(x => x.CustomerId == Int32.Parse(tbxIdCustomer.Text)).OrderByDescending(x => x.OrderDate).Select(x => x.OrderDate).ToList());
                OrderSelected.ItemsSource = TimeOrder.ToList();
            }
        }

        private void OrderDetail_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
