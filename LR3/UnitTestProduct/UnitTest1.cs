using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LR3;

namespace LR3
{
    [TestClass]
    public class ProductTests
    {
        private string csvPath = @"D:\01.01\LR3\LR3\bin\Debug\data.csv";

        // ТЕСТ 1: Проверка количества категорий и товаров
        [TestMethod]
        public void Test_ReadCsv_CountsCategoriesCorrectly()
        {
            // Arrange
            var categories = new Dictionary<string, int>();

            // Act
            using (StreamReader reader = new StreamReader(csvPath, Encoding.GetEncoding(1251)))
            {
                reader.ReadLine(); // пропустить заголовок
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(';');
                    if (parts.Length < 7) continue;

                    string category = parts[0].Trim();

                    if (categories.ContainsKey(category))
                        categories[category]++;
                    else
                        categories[category] = 1;
                }
            }

            // Assert
            Assert.AreEqual(2, categories.Count, "Должно быть 1 категории");
            Assert.IsTrue(categories.ContainsKey("Dairy products"), "Должна быть категория Dairy products");
            Assert.IsTrue(categories.ContainsKey("Drinks"), "Должна быть категория Drinks");
            Assert.AreEqual(1, categories["Dairy products"], "В Dairy products должно быть 1 товара");
            Assert.AreEqual(2, categories["Drinks"], "В Drinks должно быть 2 товара");
        }

        // ТЕСТ 2: Проверка создания товара с корректной ценой
        [TestMethod]
        public void Test_ProductCreation_ValidPrice()
        {
            // Arrange & Act
            var product = new Product("Milk 3.2%", "80", "Prostokvashino", "20.05.2026", "Magnit", "https://example.com/milk.jpg");

            // Assert
            Assert.AreEqual("Milk 3.2%", product.Name);
            Assert.AreEqual("80 руб.", product.Price);
            Assert.AreEqual("Prostokvashino", product.Manufacturer);
            Assert.AreEqual("20.05.2026", product.Date);
            Assert.AreEqual("Magnit", product.Provider);
        }

        // ТЕСТ 3: Проверка создания товара с некорректной ценой
        [TestMethod]
        public void Test_ProductCreation_InvalidPrice_ReturnsZero()
        {
            // Act
            var product1 = new Product("Test1", "не число", "Manufacturer", "20.05.2026", "Provider", "path.jpg");
            var product2 = new Product("Test2", "", "Manufacturer", "20.05.2026", "Provider", "path.jpg");
            var product3 = new Product("Test3", "abc123", "Manufacturer", "20.05.2026", "Provider", "path.jpg");

            // Assert
            Assert.AreEqual("0 руб.", product1.Price, "При неверной цене должно быть 0 руб.");
            Assert.AreEqual("0 руб.", product2.Price, "При пустой цене должно быть 0 руб.");
            Assert.AreEqual("0 руб.", product3.Price, "При нечисловой цене должно быть 0 руб.");
        }

        // ТЕСТ 4: Проверка всех полей товара
        [TestMethod]
        public void Test_ProductFields_AllFieldsSetCorrectly()
        {
            // Arrange
            string name = "Test Product";
            string price = "150";
            string manufacturer = "Test Manufacturer";
            string date = "15.12.2027";
            string provider = "Test Provider";
            string imagePath = "https://example.com/test.jpg";

            // Act
            var product = new Product(name, price, manufacturer, date, provider, imagePath);

            // Assert
            Assert.AreEqual(name, product.Name);
            Assert.AreEqual(manufacturer, product.Manufacturer);
            Assert.AreEqual("150 руб.", product.Price);
            Assert.AreEqual(date, product.Date);
            Assert.AreEqual(provider, product.Provider);
            Assert.AreEqual(imagePath, product.ImagePath);
        }

        // ТЕСТ 5: Проверка чтения конкретных товаров из CSV
        [TestMethod]
        public void Test_ReadCsv_SpecificProductValues()
        {
            // Arrange
            var products = new List<Product>();

            // Act
            using (StreamReader reader = new StreamReader(csvPath, Encoding.GetEncoding(1251)))
            {
                reader.ReadLine(); // пропустить заголовок
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(';');
                    if (parts.Length >= 7)
                    {
                        var product = new Product(
                            parts[1].Trim(),  // name
                            parts[2].Trim(),  // price
                            parts[3].Trim(),  // manufacturer
                            parts[4].Trim(),  // date
                            parts[5].Trim(),  // provider
                            parts[6].Trim()   // imagePath
                        );
                        products.Add(product);
                    }
                }
            }

            Assert.AreEqual("Natural yogurt", products[0].Name);
            Assert.AreEqual("55 руб.", products[0].Price);
            Assert.AreEqual("Activia", products[0].Manufacturer);


            Assert.AreEqual("Orange juice", products[1].Name);
            Assert.AreEqual("120 руб.", products[1].Price);
            Assert.AreEqual("Dobry", products[1].Manufacturer);

            Assert.AreEqual("Mineral water", products[2].Name);
            Assert.AreEqual("45 руб.", products[2].Price);
            Assert.AreEqual("Holy Spring", products[2].Manufacturer);
        }
    }
}