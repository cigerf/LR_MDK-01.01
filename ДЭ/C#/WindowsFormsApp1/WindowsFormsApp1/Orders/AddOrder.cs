using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Delivery_Points;

namespace WindowsFormsApp1.Orders
{
    // Форма для добавления нового заказа
    public partial class AddOrder : Form
    {
        // Загрузчик заказов для работы с базой данных
        PgOrderLoader orderLoader_;

        // Загрузчик пунктов доставки для получения списка адресов
        PgDeliveryPointLoader deliveryPointLoader_;

        // Конструктор формы добавления заказа
        public AddOrder(PgOrderLoader orderLoader, PgDeliveryPointLoader deliveryPointLoader)
        {
            InitializeComponent();

            orderLoader_ = orderLoader;

            deliveryPointLoader_ = deliveryPointLoader;
            var deliveryPoints = deliveryPointLoader_.Load();
            PickupPointAddressComboBox.DataSource = deliveryPoints;
            PickupPointAddressComboBox.DisplayMember = "Address";
            PickupPointAddressComboBox.ValueMember = "Address";

        }

        // Метод для заполнения полей формы данными существующего заказа
        public void SetOrder(Order order)
        {
            OrderNumberNumericUpDown.Value = order.orderNumber;
            OrderDateDateTimePicker.Value = order.orderDate;
            DeliveryDateDateTimePicker.Value = order.deliveryDate;
            PickupPointAddressComboBox.Text = order.pickupPointAddress;
            ClientFullNameTextBox.Text = order.clientFullName;
            PickupCodeTextBox.Text = order.pickupCode;
            OrderStatusComboBox.Text = order.orderStatus;
        }

        // Обработчик кнопки "Отмена"
        private void CanselButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обработчик кнопки "Добавить заказ"
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ClientFullNameTextBox.Text)
               || string.IsNullOrWhiteSpace(OrderStatusComboBox.Text))
            {
                MessageBox.Show("Не все обязательные поля были заполнены!", "Внимание");
                return;
            }
            Order order = new Order
            {
                OrderNumber = (int)OrderNumberNumericUpDown.Value,
                OrderDate = OrderDateDateTimePicker.Value,
                DeliveryDate = DeliveryDateDateTimePicker.Value,
                PickupPointAddress = PickupPointAddressComboBox.Text,
                ClientFullName = ClientFullNameTextBox.Text,
                PickupCode = PickupCodeTextBox.Text,
                OrderStatus = OrderStatusComboBox.Text
            };

            orderLoader_.AddOrder(order);
        }
    }
}
