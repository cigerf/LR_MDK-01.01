using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TestBd
{
    public partial class MainForm: Form
    {
        PgUsersLoader loader = new PgUsersLoader();
        public MainForm()
        {
            InitializeComponent();
            usersDataGridView.DataSource = loader.LoadUsers();

            //var cs = "Host=192.168.1.48;Username=postgres;Password=PG@dmin$;Database=proptest";
            //var con = new NpgsqlConnection(cs);

            //con.Open();
            //var sql = "SELECT password,login FROM myusers";
            //var cmd = new NpgsqlCommand(sql, con);

            //var reader = cmd.ExecuteReader();
            //List<string> Logins = new List<string>();
            //while (reader.Read())
            //{
            //    Logins.Add(reader.GetString(0) + ":" + reader.GetString(1));
            //}
            //MessageBox.Show(string.Join(",", PgUsersLoader.LoadUse));
            //con.Close();
        }
    }
}
