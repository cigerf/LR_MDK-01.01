using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class SalesModel
    {
        private Dictionary<Item, List<Sale>> salesByItems_ = new Dictionary<Item, List<Sale>>();
        public void AddSales(Item item, List<Sale> sales)
        {
            if (salesByItems_.ContainsKey(item))
            {
                salesByItems_[item].AddRange(sales);
            }
            else
            {
                salesByItems_.Add(item, sales);
            }
        }
        public List<Sale> LoadSalesForItem(string itemName)
        {
            List<Item> allItems = salesByItems_.Keys.ToList();
            Item targetItem = allItems.Find(item => item.Name == itemName);
            if (targetItem != null)
            {
                return salesByItems_[targetItem];
            }

            return new List<Sale>();
        }
        public bool Load()
        {
            AddSales(new Item { Name = "Чай Улун", Price = 100 },
                new List<Sale>() {
                     new Sale {Date = new System.DateTime(2026, 3, 13), Count =10 },
                     new Sale {Date = new System.DateTime(2026, 3, 15), Count =20 },
                     new Sale {Date = new System.DateTime(2026, 3, 11), Count =3 },
                     new Sale {Date = new System.DateTime(2026, 3, 8), Count =7 },
                });

            AddSales(new Item { Name = "Тархун", Price = 75 },
                new List<Sale>() {
                     new Sale {Date = new System.DateTime(2026, 3, 13), Count =20 },
                     new Sale {Date = new System.DateTime(2026, 3, 15), Count =17 },
                     new Sale {Date = new System.DateTime(2026, 3, 11), Count =13 },
                     new Sale {Date = new System.DateTime(2026, 3, 8), Count =24 },
               });
            AddSales(new Item { Name = "Черноголовка", Price = 90 },
                new List<Sale>() {
                     new Sale {Date = new System.DateTime(2026, 3, 13), Count =14 },
                     new Sale {Date = new System.DateTime(2026, 3, 15), Count =34 },
                     new Sale {Date = new System.DateTime(2026, 3, 11), Count =28 },
                     new Sale {Date = new System.DateTime(2026, 3, 8), Count =11 },
               });
            AddSales(new Item { Name = "Американо", Price = 250 },
                new List<Sale>()
                {
                    new Sale {Date = new System.DateTime(2026, 3, 13), Count =14 },
                     new Sale {Date = new System.DateTime(2026, 3, 15), Count =25 },
                     new Sale {Date = new System.DateTime(2026, 3, 11), Count =5 },
                     new Sale {Date = new System.DateTime(2026, 3, 8), Count =52 },
                });
            return true;
        }
        public List<Item> GetAllItems()
        {
            return salesByItems_.Keys.ToList();
        }

        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach (KeyValuePair<Item, List<Sale>> keyValue in salesByItems_)
            {
                Item item = keyValue.Key;
                result += keyValue.Value.Sum(sale => sale.Count * item.Price);
            }

            return result;
        }

        public Item GetItem(string itemName)
        {
            foreach (KeyValuePair<Item, List<Sale>> keyValue in salesByItems_)
            {
                Item item = keyValue.Key;
                if (item.Name == itemName)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
