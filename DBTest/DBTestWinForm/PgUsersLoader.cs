using Npgsql;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public class PgUsersLoader
    {
        BindingList<User> AllUsers = new BindingList<User>();
        private const string connectSetting = "Host=192.168.1.48;Username=st50-10;Password=5010;Database=test01";
        public BindingList<User> Load() 
        {
            try
            {               
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password, name, last_name, age From users";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Name = reader.GetString(2),
                        LastName = reader.GetString(3),
                        Age = reader.GetInt32(4),
                    };
                    AllUsers.Add(user);
                }
                return AllUsers;
            }
            catch(NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }         
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
            catch(NpgsqlException exception) 
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        public bool ClearAllUsers() 
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM users";
                var cmd = new NpgsqlCommand(sql, con);
               
                    int execute = cmd.ExecuteNonQuery();
                    if (execute > 0)
                    {
                        result = true;
                        AllUsers.Clear();
                    }
                    return result;                
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        public bool AddUser(User user) 
        {
            try 
            {
                bool addResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO users(login, password, name, last_name, age) VALUES(@login, @password, @name ,@last_name, @age)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@age", user.Age);
                cmd.Parameters.AddWithValue("@last_name", user.LastName);
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
        public bool EditUser(User user)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "UPDATE users SET password = @password, name = @name, age = @age, last_name = @last_name Where login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@age", user.Age);
                cmd.Parameters.AddWithValue("@last_name", user.LastName);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    for (int i = 0; i < AllUsers.Count; i++)
                    {
                        if (AllUsers[i].Login == user.Login)
                        {
                            AllUsers[i].Age = user.Age;
                            AllUsers[i].Password = user.Password;
                            AllUsers[i].Name = user.Name;
                            AllUsers[i].LastName = user.LastName;
                        }
                    }
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
