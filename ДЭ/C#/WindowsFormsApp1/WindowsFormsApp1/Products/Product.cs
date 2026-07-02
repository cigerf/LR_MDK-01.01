using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Класс товара с поддержкой уведомлений об изменениях свойств
    public class Product : INotifyPropertyChanged
    {
        public string article;
        public string productName;
        public string unitOfMeasurement;
        public decimal price;
        public string supplier;
        public string manufacturer;
        public string productCategory;
        public int currentDiscount;
        public int stockQuantity;
        public string productDescription;
        public string photo;

        [DisplayName("Артикул")]
        public string Article
        {
            get { return article; }
            set
            {
                article = value;
                OnPropertyChanged("Article");
            }
        }

        [DisplayName("Наименование товара")]
        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                OnPropertyChanged("ProductName");
            }
        }

        [DisplayName("Единица измерения")]
        public string UnitOfMeasurement
        {
            get { return unitOfMeasurement; }
            set
            {
                unitOfMeasurement = value;
                OnPropertyChanged("UnitOfMeasurement");
            }
        }

        [DisplayName("Цена")]
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        [DisplayName("Поставщик")]
        public string Supplier
        {
            get { return supplier; }
            set
            {
                supplier = value;
                OnPropertyChanged("Supplier");
            }
        }

        [DisplayName("Производитель")]
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                manufacturer = value;
                OnPropertyChanged("Manufacturer");
            }
        }

        [DisplayName("Категория товара")]
        public string ProductCategory
        {
            get { return productCategory; }
            set
            {
                productCategory = value;
                OnPropertyChanged("ProductCategory");
            }
        }

        [DisplayName("Действующая скидка")]
        public int CurrentDiscount
        {
            get { return currentDiscount; }
            set
            {
                currentDiscount = value;
                OnPropertyChanged("CurrentDiscount");
            }
        }

        [DisplayName("Кол-во на складе")]
        public int StockQuantity
        {
            get { return stockQuantity; }
            set
            {
                stockQuantity = value;
                OnPropertyChanged("StockQuantity");
            }
        }

        [DisplayName("Описание товара")]
        public string ProductDescription
        {
            get { return productDescription; }
            set
            {
                productDescription = value;
                OnPropertyChanged("ProductDescription");
            }
        }

        [DisplayName("Фото")]
        public string Photo
        {
            get { return photo; }
            set
            {
                photo = value;
                OnPropertyChanged("Photo");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}