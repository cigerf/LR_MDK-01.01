using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBd
{
    public class PgUsersLoader
    {
        public string cs = "Host=192.168.1.48;Username=postgres;Password=PG@dmin$;Database=proptest";
        public List<User> LoadUsers()
        {
            try
            {
                List<User> allUsers = new List<User>();
                var con = new NpgsqlConnection(cs);

                con.Open();
                var sql = "SELECT login,password,name,last_name,age FROM myusers";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allUsers.Add(new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Name = reader.GetString(2),
                        Last_name = reader.GetString(3),
                        Age = reader.GetInt32(4)
                    });
                }
                con.Close();

                return allUsers;
            } catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool DeleteUser(string login)
        {
            try
            {
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = @"DELETE FROM myusers WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                int changedRows = cmd.ExecuteNonQuery();

                if (changedRows < 1)
                {
                    return false;
                }
                return true;
            } catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}