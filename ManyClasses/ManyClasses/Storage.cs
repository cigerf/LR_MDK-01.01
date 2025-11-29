using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    public class Storage
    {
        private int id_;
        private string location_;
        private Dictionary<Product, int> products_ = new Dictionary<Product, int>();

        public void SetId(int id)
        {
            id_ = id;
        }
        public void SetLocation(string location)
        {
            location_ = location;
        }
        public void SetProductQuantity(Product product, int quantity) 
        {
            products_.Add(product, quantity);
        }
        public void GetProductQuantity()
        {
            foreach (Product product in products_.Keys)
            {
                Console.WriteLine(product.GetName() + " - " + products_[product]);
            }
        }
        public void CalculateMoney()
        {
            double sum = 0;
            foreach (Product product in products_.Keys)
            {
                sum += product.GetPrice() * products_[product];
            }
            Console.WriteLine(sum);
        }
    }
}
