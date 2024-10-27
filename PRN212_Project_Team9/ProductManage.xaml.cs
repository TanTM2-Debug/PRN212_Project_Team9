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
    /// Interaction logic for ProductManage.xaml
    /// </summary>
    public partial class ProductManage : Window
    {
        SalesManagementDbContext db = new SalesManagementDbContext();
        public ProductManage()
        {
            InitializeComponent();
            LoadLvProduct();
            LoadCbCategory();
        }

        public void LoadLvProduct()
        {
            var listProduct = db.Products.Select(x => new
            {
                ProductID = x.ProductId,
                ProductName = x.ProductName,
                Category = x.Category.CategoryName,
                Price = x.Price,
                StockQuantity = x.StockQuantity,
                Description = x.Description,
            }).ToList();
            lvProduct.ItemsSource = listProduct;
        }

        public void LoadCbCategory()
        {
            var listCategory = db.Categories.Select(x => x.CategoryName).ToList();
            cbCategory.ItemsSource = listCategory;
            cbCategory.SelectedIndex = 0;
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = lvProduct.SelectedItem as dynamic;
            if (selectedProduct != null)
            {
                txtProductID.Text = selectedProduct.ProductID.ToString();
                txtProductName.Text = selectedProduct.ProductName;
                cbCategory.Text = selectedProduct.Category;
                txtPrice.Text = selectedProduct.Price.ToString();
                txtStockQuantity.Text = selectedProduct.StockQuantity.ToString();
                txtDescription.Text = selectedProduct.Description;
            }
        }
    }
}
