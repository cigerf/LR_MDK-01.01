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
        public List<User> LoadUsers()
        {
            List<User> allUsers = new List<User>();
            var cs = "Host=192.168.1.48;Username=postgres;Password=PG@dmin$;Database=proptest";
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
        }
    }
}
