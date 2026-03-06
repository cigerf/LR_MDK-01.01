using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Product
    {
        private string name_;
        private int price_;
        private string manufacturer_;
        private DateTime shelfLifeDate_;
        private string provider_;
        private string imagePath_;
        public Product(string name, string price, string manufacturer, string date, string provider, string imagePath)
        {
            name_ = name;
            if (!int.TryParse(price, out price_))
            {
                price_ = 0;
            }
            manufacturer_ = manufacturer;
            shelfLifeDate_ = DateTime.Parse(date);
            provider_ = provider;
            imagePath_ = imagePath;
        }
        public string Name 
        {
            get { return name_; }
        }
        public string Price 
        {
            get { return price_.ToString(); }
        }
        public string Manufacturer 
        {
            get { return manufacturer_; }
        }
        public string Date 
        { 
            get { return shelfLifeDate_.ToString("dd.MM.yyyy"); }
        }
        public string Provider
        { 
            get { return provider_; } 
        }
        public string ImagePath 
        {
            get { return imagePath_; }
        }
    }
}
