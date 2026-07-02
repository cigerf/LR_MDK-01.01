using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    // Класс для загрузки и управления пользователями из базы данных PostgreSQL
    public class PgUserLoader
    {
        // Список всех пользователей, загруженных из БД
        BindingList<User> AllUsers = new BindingList<User>();
        private const string connectSetting = "Host=localhost;Username=postgres;Password=123;Database=xyinya";
        // Загрузка всех пользователей из базы данных
        public BindingList<User> Load()
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT role, full_name, login, password From users";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Role = reader.GetString(0),
                        FullName = reader.GetString(1),
                        Login = reader.GetString(2),
                        Password = reader.GetString(3),
                    };
                    AllUsers.Add(user);
                }
                return AllUsers;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }
        // Удаление пользователя из базы данных по логину
        public bool DeleteSelectedUser(string Login)
        {
            try
            {
                bool deleteResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM users Where login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", Login);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    deleteResult = true;
                    for (int index = 0; index < AllUsers.Count; index++)
                    {
                        if (AllUsers[index].Login == Login)
                        {
                            AllUsers.RemoveAt(index);
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
        // Добавление нового пользователя в базу данных
        public bool AddUser(User user)
        {
            try
            {
                bool addResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO users(role, full_name, login, password) VALUES(@role, @fullname, @login ,@password)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@fullname", user.FullName);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    addResult = true;
                    AllUsers.Add(user);
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
