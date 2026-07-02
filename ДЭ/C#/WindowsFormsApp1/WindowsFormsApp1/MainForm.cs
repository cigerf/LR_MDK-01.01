using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Delivery_Points;
using WindowsFormsApp1.Orders;
using WindowsFormsApp1.Products;
using WindowsFormsApp1.Users;

namespace WindowsFormsApp1
{

    public partial class MainForm : Form
    {
        // Загрузчики данных для разных сущностей
        PgUserLoader userloader = new PgUserLoader();
        PgProductLoader productLoader = new PgProductLoader();
        PgDeliveryPointLoader DeliveryPointLoader = new PgDeliveryPointLoader();
        PgOrderLoader orderLoader = new PgOrderLoader();
       
        // Конструктор главной формы
        public MainForm()
        {
            InitializeComponent();


            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingList<User> users = userloader.Load();
            dataGridViewUsers.DataSource = users;


            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingList<Product> products = productLoader.Load();
            dataGridViewProducts.DataSource = products;
                  

            dataGridViewDeliveryPoint.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingList<DeliveryPoint> deliveryPoint = DeliveryPointLoader.Load();
            dataGridViewDeliveryPoint.DataSource = deliveryPoint;
            
       
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingList<Order> orders = orderLoader.Load(DeliveryPointLoader);
            dataGridViewOrders.DataSource = orders;

        }



        // Обработчик кнопки "Добавить пользователя"
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUsers addUsers = new AddUsers(userloader);
            addUsers.Show();
        }

        // Обработчик кнопки "Удалить пользователя"
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewUsers.SelectedRows[0];
                User user = row.DataBoundItem as User;
                userloader.DeleteSelectedUser(user.Login);
            }
        }





        // Обработчик кнопки "Добавить товар"   
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(productLoader);
            addProduct.Show();
        }

        // Обработчик кнопки "Удалить товар"
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewProducts.SelectedRows[0];
                Product product = row.DataBoundItem as Product;
                productLoader.DeleteSelectedProduct(product.Article);
            }
        }





        // Обработчик кнопки "Добавить пункт доставки"
        private void AddDeliveryPointButton_Click(object sender, EventArgs e)
        {
            AddDeliveryPoint addDeliveryPoint = new AddDeliveryPoint(DeliveryPointLoader);
            addDeliveryPoint.Show();
        }

        // Обработчик кнопки "Удалить пункт доставки"
        private void DeleteDeliveryPointButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewDeliveryPoint.SelectedRows[0];
                DeliveryPoint deliveryPoint = row.DataBoundItem as DeliveryPoint;
                DeliveryPointLoader.DeleteSelectedDeliveryPoint(deliveryPoint.Address);
            }
        }


        // Обработчик кнопки "Добавить заказ"
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder(orderLoader, DeliveryPointLoader);
            addOrder.Show();
        }

        // Обработчик кнопки "Удалить заказ"
        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewOrders.SelectedRows[0];
                Order order = row.DataBoundItem as Order;
                orderLoader.DeleteSelectedOrder(order.PickupCode);
            }

        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewProducts.SelectedRows[0];
            Product product = row.DataBoundItem as Product;
            pictureBox1.ImageLocation = product.photo;
        }
    }
}
