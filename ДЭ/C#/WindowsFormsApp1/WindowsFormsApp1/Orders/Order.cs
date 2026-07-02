using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Класс заказа с поддержкой уведомлений об изменениях свойств
    public class Order : INotifyPropertyChanged
    {
        public int orderNumber;
        public DateTime orderDate;
        public DateTime deliveryDate;
        public string pickupPointAddress;
        public string clientFullName;
        public string pickupCode;
        public string orderStatus;

        [DisplayName("Номер заказа")]
        public int OrderNumber
        {
            get { return orderNumber; }
            set
            {
                orderNumber = value;
                OnPropertyChanged("OrderNumber");
            }
        }

        [DisplayName("Дата заказа")]
        public DateTime OrderDate
        {
            get { return orderDate; }
            set
            {
                orderDate = value;
                OnPropertyChanged("OrderDate");
            }
        }

        [DisplayName("Дата доставки")]
        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set
            {
                deliveryDate = value;
                OnPropertyChanged("DeliveryDate");
            }
        }

        [DisplayName("Адрес пункта выдачи")]
        public string PickupPointAddress
        {
            get { return pickupPointAddress; }
            set
            {
                pickupPointAddress = value;
                OnPropertyChanged("PickupPointAddress");
            }
        }

        [DisplayName("ФИО клиента")]
        public string ClientFullName
        {
            get { return clientFullName; }
            set
            {
                clientFullName = value;
                OnPropertyChanged("ClientFullName");
            }
        }

        [DisplayName("Код для получения")]
        public string PickupCode
        {
            get { return pickupCode; }
            set
            {
                pickupCode = value;
                OnPropertyChanged("PickupCode");
            }
        }

        [DisplayName("Статус заказа")]
        public string OrderStatus
        {
            get { return orderStatus; }
            set
            {
                orderStatus = value;
                OnPropertyChanged("OrderStatus");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}