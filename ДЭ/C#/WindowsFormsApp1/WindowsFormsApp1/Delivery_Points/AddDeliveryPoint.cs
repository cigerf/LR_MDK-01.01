using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Delivery_Points
{
    // Форма для добавления нового пункта доставки
    public partial class AddDeliveryPoint : Form
    {
        PgDeliveryPointLoader pointLoader_;
        // Конструктор формы добавления пункта доставки
        public AddDeliveryPoint(PgDeliveryPointLoader pointLoader)
        {
            InitializeComponent();
            pointLoader_ = pointLoader;
        }
        // Заполняет поля формы данными существующего пункта доставки для редактирования
        public void SetPickupPoint(DeliveryPoint deliveryPoint)
        {
            AddressTextBox.Text = deliveryPoint.address;
        }
        // Закрывает форму без сохранения изменений
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Проверяет введенные данные и добавляет новый пункт доставки
        private void AddPointButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                MessageBox.Show("Не все обязательные поля были заполнены!", "Внимание");
                return;
            }
            DeliveryPoint deliveryPoint = new DeliveryPoint
            {
                Address = AddressTextBox.Text,
            };
            pointLoader_.AddDeliveryPoint(deliveryPoint);
        }

    }
}
