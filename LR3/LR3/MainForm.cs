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
        Dictionary<string, List<Product>> product_ = new Dictionary<string, List<Product>>();
        Dictionary<string, int> orderItems_ = new Dictionary<string, int>();
        public MainForm()
        {
            InitializeComponent();

            product_.Add("Молочная продукция",
                new List<Product>()
                {
                    new Product("Снежок термостатный", 100, "ОАО Молоко",new DateTime(2026, 02, 21), "Пятерочка", "Снежок.png"),
                    new Product("Саянская легенда", 250, "ОАО Молоко",new DateTime(2026, 03, 7), "Пятерочка", "Саянская легенда.png")
                }
            );

            product_.Add("Овощи",
                new List<Product>()
                {
                    new Product("Морковка", 65, "ООО Фермерская лавка",new DateTime(2026, 02, 28), "Магнит", "Морковка.png"),
                }
            );
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
                DrugPictureBox.Load(selectedProduct.ImagePath);
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
                string orderText = "Заказ:\n";
                foreach (var item in orderItems_)
                {
                    orderText += $"{item.Key}: {item.Value} шт.\n";
                }

                MessageBox.Show(orderText, "Текущий заказ");
            }
        }
    }
}