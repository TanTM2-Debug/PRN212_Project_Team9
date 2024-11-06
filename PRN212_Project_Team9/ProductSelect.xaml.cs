using Microsoft.EntityFrameworkCore;
using PRN212_Project_Team9.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for ProductSelect.xaml
    /// </summary>
    public partial class ProductSelect : Window
    {
        SalesManagementDbContext _con = new SalesManagementDbContext();
        public ProductSelect()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DateTime currentTime = DateTime.Now;

            DataProductListToOrder.ItemsSource = _con.Products.Select(x => new
            {
                x.ProductId,
                x.ProductName,
                x.CategoryId,
                x.Price,
                x.StockQuantity,
            }).ToList();

        }

        private void DataProductListToOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var productSelect = DataProductListToOrder.SelectedItems;

            if (productSelect != null)
            {
                DiscountsOfProduct.ItemsSource = _con.ProductDiscounts.Where(x => x.ProductId == productSelect.).ToList();







            }


        }
    }
}
