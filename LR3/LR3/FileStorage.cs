using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    internal class FileStorage : ILoadProduct
    {
        public Dictionary<string, List<Product>> LoadDataFromCsv()
        {
            Dictionary<string, List<Product>> result = new Dictionary<string, List<Product>>();

            using (StreamReader reader = new StreamReader("data.csv", Encoding.GetEncoding(1251)))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] ProductInfo = line.Split(';');

                    string category = ProductInfo[0];
                    string name = ProductInfo[1];
                    string price = ProductInfo[2];
                    string manufacturer = ProductInfo[3];
                    string date = ProductInfo[4];
                    string provider = ProductInfo[5];
                    string imagePath = ProductInfo[6];

                    Product product = new Product(name, price, manufacturer, date, provider, imagePath);

                    if (!result.ContainsKey(category))
                    {
                        result[category] = new List<Product>();
                    }

                    result[category].Add(product);
                }
            }

            return result;
        }
    }
}