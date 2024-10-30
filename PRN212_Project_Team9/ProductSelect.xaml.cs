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
            DataProductListToOrder.ItemsSource = _con.Products.Include(x => x.ProductDiscounts).Select(x => new
            {
                x.ProductId,
                x.ProductName,
                x.CategoryId,
                PriceCurrent = x.Price ,

            });
        }
    }
}
