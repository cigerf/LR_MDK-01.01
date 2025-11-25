using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    public class Product
    {
        private string name_;
        private double price_;
        public string GetName()
        {
            return name_;
        }
        public double GetPrice()
        {
            return price_;
        }
        public void SetName(string name)
        {
            name_ = name;
        }
        public void SetPrice(double price)
        {
            price_ = price;
        }
    }
}
