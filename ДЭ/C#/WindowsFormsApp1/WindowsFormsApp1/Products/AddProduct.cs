using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Products
{
    // Форма для добавления нового товара
    public partial class AddProduct : Form
    {
        // Загрузчик товаров для работы с базой данных
        PgProductLoader productLoader_;
        // Конструктор формы добавления товара
        public AddProduct(PgProductLoader productLoader)
        {
            InitializeComponent();
            productLoader_ = productLoader;
        }
        // Метод для заполнения полей формы данными существующего товара
        public void SetProduct(Product product)
        {
            ArticleTextBox.Text = product.article;
            ProductNameTextBox.Text = product.productName;
            UnitOfMeasurementTextBox.Text = product.unitOfMeasurement;
            PriceNumericUpDown.Value = product.price;
            SupplierTextBox.Text = product.supplier;
            ManufacturerTextBox.Text = product.manufacturer;
            ProductCategoryTextBox.Text = product.productCategory;
            CurrentDiscountNumericUpDown.Value = product.currentDiscount;
            StockQuantityNumericUpDown.Value = product.stockQuantity;
            ProductDescriptionTextBox.Text = product.productDescription;
            PhotoTextBox.Text = product.photo;
        }
        // Обработчик кнопки "Отмена"
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Обработчик кнопки "Добавить товар"
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ArticleTextBox.Text)
                    || string.IsNullOrWhiteSpace(ProductNameTextBox.Text))
            {
                MessageBox.Show("Не все обязательные поля были заполнены!", "Внимание");
                return;
            }

            Product product = new Product
            {
                Article = ArticleTextBox.Text,
                ProductName = ProductNameTextBox.Text,
                UnitOfMeasurement = UnitOfMeasurementTextBox.Text,
                Price = PriceNumericUpDown.Value,
                Supplier = SupplierTextBox.Text,
                Manufacturer = ManufacturerTextBox.Text,
                ProductCategory = ProductCategoryTextBox.Text,
                CurrentDiscount = (int)CurrentDiscountNumericUpDown.Value,
                StockQuantity = (int)StockQuantityNumericUpDown.Value,
                ProductDescription = ProductDescriptionTextBox.Text,
                Photo = PhotoTextBox.Text
            };
            productLoader_.AddProduct(product);
        }
    }
}
