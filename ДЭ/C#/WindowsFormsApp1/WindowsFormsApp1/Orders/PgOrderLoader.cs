using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Delivery_Points;
using WindowsFormsApp1.Users;

namespace WindowsFormsApp1.Orders
{
    // Класс для загрузки и управления заказами из базы данных
    public class PgOrderLoader
    {
        // Коллекция всех заказов с поддержкой уведомлений об изменениях
        BindingList<Order> orders = new BindingList<Order>();
        private const string connectSetting = "Host=localhost;Username=postgres;Password=123;Database=xyinya";
        // Метод загрузки всех заказов из БД
        public BindingList<Order> Load(PgDeliveryPointLoader pointLoader)
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT order_number, order_date, delivery_date, pickup_point_address, client_full_name, pickup_code, order_status FROM orders";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order order = new Order
                    {
                        OrderNumber = reader.GetInt32(0),
                        OrderDate = reader.GetDateTime(1),
                        DeliveryDate = reader.GetDateTime(2),
                        PickupPointAddress = reader.GetString(3),
                        ClientFullName = reader.GetString(4),
                        PickupCode = reader.GetString(5),
                        OrderStatus = reader.GetString(6)
                    };
                    orders.Add(order);
                }
                return orders;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }
        // Метод удаления заказа по коду получения
        public bool DeleteSelectedOrder(string pickupCode)
        {
            try
            {
                bool deleteResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM orders WHERE pickup_code = @pickupCode";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pickupCode", pickupCode);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    deleteResult = true;
                    for (int index = 0; index < orders.Count; index++)
                    {
                        if (orders[index].PickupCode == pickupCode)
                        {
                            orders.RemoveAt(index);
                            index--;
                        }
                    }
                }
                return deleteResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        // Метод добавления нового заказа
        public bool AddOrder(Order order)
        {
            try
            {
                bool addResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = @"INSERT INTO orders(order_number, order_date, delivery_date, pickup_point_address, client_full_name, pickup_code, order_status) 
                    VALUES(@orderNumber, @orderDate, @deliveryDate, @pickupPointAddress, @clientFullName, @pickupCode, @orderStatus)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@orderNumber", order.OrderNumber);
                cmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@deliveryDate", order.DeliveryDate);
                cmd.Parameters.AddWithValue("@pickupPointAddress", order.PickupPointAddress);
                cmd.Parameters.AddWithValue("@clientFullName", order.ClientFullName);
                cmd.Parameters.AddWithValue("@pickupCode", order.PickupCode);
                cmd.Parameters.AddWithValue("@orderStatus", order.OrderStatus);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    addResult = true;
                    orders.Add(order);
                }
                return addResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
    }
}