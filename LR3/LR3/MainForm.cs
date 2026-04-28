using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Product>> product_ = new Dictionary<string, List<Product>>();
        private Dictionary<string, int> orderItems_ = new Dictionary<string, int>();
        private FileStorage fileStorage = new FileStorage();
        public MainForm()
        {
            InitializeComponent();
            product_ = fileStorage.LoadDataFromCsv();
            List<string> allCategories = product_.Keys.ToList();
            CategoriesListBox.DataSource = allCategories;

        }
        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = CategoriesListBox.SelectedItem.ToString();
            List<Product> ProductSelectedCategory = product_[selectedCategory];
            ProductComboBox.DataSource = ProductSelectedCategory;
            ProductComboBox.DisplayMember = "Name";
        }
        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = ProductComboBox.SelectedItem as Product;
            if (selectedProduct != null)
            {
                PriceLabel.Text = selectedProduct.Price;
                ManufacturerLabel.Text = selectedProduct.Manufacturer;
                DateLabel.Text = selectedProduct.Date;
                ProviderLabel.Text = selectedProduct.Provider;
                ProductPictureBox.Load(selectedProduct.ImagePath);
            }
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = ProductComboBox.SelectedItem as Product;
            if (selectedProduct != null)
            {
                string ProductName = selectedProduct.Name;
                int quantity = (int)QuantityNumericUpDown.Value;
                if (orderItems_.ContainsKey(ProductName))
                {
                    orderItems_[ProductName] += quantity;
                }
                else
                {
                    orderItems_[ProductName] = quantity;
                }
                string orderText = "Ваш заказ:\n";
                foreach (var item in orderItems_)
                {
                    orderText += $"{item.Key}: {item.Value} шт.\n";
                }

                MessageBox.Show(orderText, "Текущий заказ");
            }
        }
    }
}