using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TestFileStorage
{
    class UsersDataBase : IUsersInterface
    {
        List<User> AllUsers = new List<User>();
        private const string connectSetting = "Host=192.168.1.48;Username=st50-10;Password=5010;Database=test01";
        public List<User> Load()
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password FROM users";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                        User user = new User(reader.GetString(0), reader.GetString(1));
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
        public bool UserRegistration(User us)
        {
            try
            {
                bool addResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO users(login, password) VALUES(@login, @password)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", us.Login);
                cmd.Parameters.AddWithValue("@password", us.Password);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    addResult = true;
                    AllUsers.Add(us);
                }
                return addResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }

        public bool UserVerification(string login)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT EXISTS(SELECT 1 FROM users WHERE login = @login)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetBoolean(0) == true) result = true;
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
    }
}
