using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Delivery_Points
{
    // Класс для загрузки и управления пунктами доставки из базы данных 
    public class PgDeliveryPointLoader
    {
        // Коллекция всех пунктов доставки с поддержкой уведомлений об изменениях
        BindingList<DeliveryPoint> DeliveryPoints = new BindingList<DeliveryPoint>();

        // Строка подключения к базе данных PostgreSQL
        private const string connectSetting = "Host=localhost;Username=postgres;Password=123;Database=xyinya";

        // Метод загрузки всех пунктов доставки из БД
        public BindingList<DeliveryPoint> Load()
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT address FROM pickup_points";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DeliveryPoint deliveryPoint = new DeliveryPoint
                    {
                        Address = reader.GetString(0),
                    };
                    DeliveryPoints.Add(deliveryPoint);
                }
                return DeliveryPoints;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }
        
        // Метод удаления пункта доставки по адресу
        public bool DeleteSelectedDeliveryPoint(string adress)
        {
            try
            {
                bool deleteResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM pickup_points Where address = @address";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@address", adress);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    deleteResult = true;
                    for (int index = 0; index < DeliveryPoints.Count; index++)
                    {
                        if (DeliveryPoints[index].Address == adress)
                        {
                            DeliveryPoints.RemoveAt(index);
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

        // Метод добавления нового пункта доставки
        public bool AddDeliveryPoint(DeliveryPoint deliveryPoint)
        {
            try
            {
                bool addResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = @"INSERT INTO pickup_points(address) VALUES(@address)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@address", deliveryPoint.Address);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    addResult = true;
                    DeliveryPoints.Add(deliveryPoint);
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
