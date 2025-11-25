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
        public Dictionary<Product, int> GetProductQuantity()
        {
            return products_;
        }
    }
}
