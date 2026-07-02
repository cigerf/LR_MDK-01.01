using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Users;

namespace WindowsFormsApp1
{
    // Класс для загрузки и управления товарами из базы данных PostgreSQL
    public class PgProductLoader
    {
       
        // Коллекция всех товаров с поддержкой уведомлений об изменениях
        BindingList<Product> allProducts = new BindingList<Product>();
        private const string connectSetting = "Host=localhost;Username=postgres;Password=123;Database=xyinya";
        // Метод загрузки всех товаров из БД
        public BindingList<Product> Load()
        {

            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT article, product_name, unit_of_measurement, price, supplier, manufacturer, product_category, current_discount, stock_quantity, product_description, photo FROM products";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Article = reader.GetString(0),
                        ProductName = reader.GetString(1),
                        UnitOfMeasurement = reader.GetString(2),
                        Price = reader.GetDecimal(3),
                        Supplier = reader.GetString(4),
                        Manufacturer = reader.GetString(5),
                        ProductCategory = reader.GetString(6),
                        CurrentDiscount = reader.GetInt32(7),
                        StockQuantity = reader.GetInt32(8),
                        ProductDescription = reader.IsDBNull(9) ? null : reader.GetString(9),
                        Photo = reader.IsDBNull(10) ? null : reader.GetString(10)
                    };
                    allProducts.Add(product);
                }
                return allProducts;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }

        // Метод удаления товара по артикулу
        public bool DeleteSelectedProduct(string article)
        {
            try
            {
                bool deleteResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM products Where article = @article";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@article", article);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    deleteResult = true;
                    for (int index = 0; index < allProducts.Count; index++)
                    {
                        if (allProducts[index].Article == article)
                        {
                            allProducts.RemoveAt(index);
                            index--;
                        }
                    }
                }
                return deleteResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        // Метод добавления нового товара
        public bool AddProduct(Product product)
        {
            try
            {
                bool addResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = @"INSERT INTO products(article, product_name, unit_of_measurement, price, supplier, manufacturer, 
                    product_category, current_discount, stock_quantity, product_description, photo) 
                    VALUES(@article, @productName, @unitOfMeasurement, @price, @supplier, @manufacturer, 
                    @productCategory, @currentDiscount, @stockQuantity, @productDescription, @photo)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@article", product.Article);
                cmd.Parameters.AddWithValue("@productName", product.ProductName);
                cmd.Parameters.AddWithValue("@unitOfMeasurement", product.UnitOfMeasurement);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@supplier", product.Supplier);
                cmd.Parameters.AddWithValue("@manufacturer", product.Manufacturer);
                cmd.Parameters.AddWithValue("@productCategory", product.ProductCategory);
                cmd.Parameters.AddWithValue("@currentDiscount", product.CurrentDiscount);
                cmd.Parameters.AddWithValue("@stockQuantity", product.StockQuantity);
                cmd.Parameters.AddWithValue("@productDescription", product.ProductDescription);
                cmd.Parameters.AddWithValue("@photo", product.Photo);

                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    addResult = true;
                    allProducts.Add(product);
                }
                return addResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
    }
}
