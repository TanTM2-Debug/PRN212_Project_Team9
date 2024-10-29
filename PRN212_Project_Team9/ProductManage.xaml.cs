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
                Quantity = db.Inventories.Where(c => c.ProductId == x.ProductId).Select(c => c.Quantity).FirstOrDefault() != null ? db.Inventories.Where(c => c.ProductId == x.ProductId).Select(c => c.Quantity).FirstOrDefault() : 0,
                Description = x.Description,
            }).ToList();
            lvProduct.ItemsSource = listProduct;

            lvProduct.SelectedItem = null;
            txtProductID.Text = "";
            txtProductName.Text = "";
            cbCategory.SelectedIndex = 0;
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtDescription.Text = "";
        }

        public void LoadLvCategory()
        {
            var listCategory = db.Categories.Select(x => new
            {
                CategoryID = x.CategoryId,
                CategoryName = x.CategoryName,
            }).ToList();
            lvCategory.ItemsSource = listCategory;

            lvCategory.SelectedItem = null;
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
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
                txtQuantity.Text = selectedProduct.Quantity.ToString();
                txtDescription.Text = selectedProduct.Description;
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadLvProduct();
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

            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please Enter Quantity!");
                return;
            }

            Product product = new Product()
            {
                ProductName = txtProductName.Text,
                Category = db.Categories.FirstOrDefault(x => x.CategoryName == cbCategory.Text),
                Price = decimal.Parse(txtPrice.Text),
                Description = txtDescription.Text,
            };


            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                Inventory inven = new Inventory()
                {
                    ProductId = product.ProductId,
                    Quantity = int.Parse(txtQuantity.Text),
                };
                db.Inventories.Add(inven);
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

            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please Enter Quantity!");
                return;
            }

            Product selectedProduct = db.Products.FirstOrDefault(x => x.ProductId == int.Parse(txtProductID.Text));

            if (selectedProduct == null)
            {
                MessageBox.Show($"Not Found ProductID = {txtProductID.Text}");
                return;
            }

            selectedProduct.ProductName = txtProductName.Text;
            selectedProduct.Category = db.Categories.FirstOrDefault(x => x.CategoryName == cbCategory.Text);
            selectedProduct.Price = decimal.Parse(txtPrice.Text);
            selectedProduct.Description = txtDescription.Text;

            Inventory inventory = db.Inventories.FirstOrDefault(x => x.ProductId == selectedProduct.ProductId);
            inventory.Quantity = int.Parse(txtQuantity.Text);
            try
            {
                db.Update(selectedProduct);
                db.Update(inventory);
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
            Inventory inventory = db.Inventories.FirstOrDefault(x => x.ProductId == product.ProductId);
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
                    db.Remove(inventory);
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
            if (selectedCategory != null)
            {
                txtCategoryId.Text = selectedCategory.CategoryID.ToString();
                txtCategoryName.Text = selectedCategory.CategoryName;
            }

           
        }

        private void btnRefreshCategory_Click(object sender, RoutedEventArgs e)
        {
            LoadLvCategory();
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
                LoadLvCategory();
                LoadCbCategory();
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
                LoadLvCategory();
                LoadCbCategory();
                LoadLvProduct();
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
                LoadLvCategory();
                LoadCbCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Delete Category {ex.Message}");
            }
        }
    }
}
