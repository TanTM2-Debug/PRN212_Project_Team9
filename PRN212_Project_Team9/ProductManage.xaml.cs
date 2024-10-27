using Microsoft.EntityFrameworkCore;
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
            LoadLvCategory();
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

        public void LoadLvCategory()
        {
            var listCategory = db.Categories.Select(x => new
            {
                CategoryID = x.CategoryId,
                CategoryName = x.CategoryName,
            }).ToList();
            lvCategory.ItemsSource = listCategory;
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

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            lvProduct.SelectedItem = null;
            txtProductID.Text = "";
            txtProductName.Text = "";
            cbCategory.SelectedIndex = 0;
            txtPrice.Text = "";
            txtStockQuantity.Text = "";
            txtDescription.Text = "";

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please Enter Product Name!");
                return;
            }

            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please Enter Price!");
                return;
            }

            if (String.IsNullOrEmpty(txtStockQuantity.Text))
            {
                MessageBox.Show("Please Enter Stock Quantity!");
                return;
            }

            Product product = new Product()
            {
                ProductName = txtProductName.Text,
                Category = db.Categories.FirstOrDefault(x => x.CategoryName == cbCategory.Text),
                Price = decimal.Parse(txtPrice.Text),
                StockQuantity = int.Parse(txtStockQuantity.Text),
                Description = txtDescription.Text,
            };
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show("Add Product Success!");
                LoadLvProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductID.Text))
            {
                MessageBox.Show("Not Found Product to Update!");
                return;
            }

            if (String.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please Enter Product Name!");
                return;
            }

            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please Enter Price!");
                return;
            }

            if (String.IsNullOrEmpty(txtStockQuantity.Text))
            {
                MessageBox.Show("Please Enter Stock Quantity!");
                return;
            }

            Product selectedProduct = db.Products.FirstOrDefault(x => x.ProductId == int.Parse(txtProductID.Text));

            if (selectedProduct != null)
            {
                MessageBox.Show("Not Found!");
                return;
            }

            selectedProduct.ProductName = txtProductName.Text;
            selectedProduct.Category = db.Categories.FirstOrDefault(x => x.CategoryName == cbCategory.Text);
            selectedProduct.Price = decimal.Parse(txtPrice.Text);
            selectedProduct.StockQuantity = int.Parse(txtStockQuantity.Text);
            selectedProduct.Description = txtDescription.Text;
            try
            {
                db.Update(selectedProduct);
                db.SaveChanges();
                MessageBox.Show("Update Product Success!");
                LoadLvProduct();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error Update: {ex.InnerException?.Message}");
            }



        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (String.IsNullOrEmpty(txtProductID.Text))
            {
                MessageBox.Show("Not Found Product to Delete!");
                return;
            }

            Product product = db.Products.FirstOrDefault(x => x.ProductId == int.Parse(txtProductID.Text));

            if (product == null)
            {
                MessageBox.Show("Not Found Product!");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    db.Remove(product);
                    db.SaveChanges();
                    MessageBox.Show("Delete Success!");
                    LoadLvProduct();
                    btnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Delete: {ex.Message}");
                }
            }
        }

        private void lvCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCategory = lvCategory.SelectedItem as dynamic;
            if (selectedCategory == null)
            {
                MessageBox.Show("Not Found Category!");
                return;
            }

            txtCategoryId.Text = selectedCategory.CategoryID.ToString();
            txtCategoryName.Text = selectedCategory.CategoryName;
        }

        private void btnRefreshCategory_Click(object sender, RoutedEventArgs e)
        {
            lvCategory.SelectedItem = null;
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
        }

        private void btnAddCategory_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Please Enter Category Name!");
                return;
            }


            Category category = new Category()
            {
                CategoryName = txtCategoryName.Text
            };

            try
            {
                db.Add(category);
                db.SaveChanges();
                MessageBox.Show("Add Category Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Add Category {ex.Message}");
            }
        }

        private void btnUpdateCategory_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCategoryId.Text))
            {
                MessageBox.Show("Not Found Category to Update!");
                return;
            }

            if (String.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Please Enter Category Name!");
                return;
            }

            Category category = db.Categories.FirstOrDefault(x => x.CategoryId == int.Parse(txtCategoryId.Text));
            if (category == null)
            {
                MessageBox.Show("Error Load Category");
                return;
            }

            category.CategoryName = txtCategoryName.Text;

            try
            {
                db.Update(category);
                db.SaveChanges();
                MessageBox.Show("Update Category Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Update Category {ex.Message}");
            }
        }

        private void btnDeleteCategory_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCategoryId.Text))
            {
                MessageBox.Show("Not Found Category to Delete!");
                return;
            }

            Category category = db.Categories.FirstOrDefault(x => x.CategoryId == int.Parse(txtCategoryId.Text));
            if (category == null)
            {
                MessageBox.Show("Error Load Category");
                return;
            }

            try
            {
                db.Remove(category);
                db.SaveChanges();
                MessageBox.Show("Delete Category Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Delete Category {ex.Message}");
            }
        }
    }
}
