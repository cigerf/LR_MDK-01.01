using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFileStorage;

namespace TestFileStorage
{
    public partial class MainForm : Form
    {
        private UsersDataBase authorization = new UsersDataBase();
        private List<string> logins = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            List<User> allUsers = new List<User>();
            allUsers = authorization.Load();

            foreach (User u in allUsers)
            {
                logins.Add(u.Login);
            }
            LoginComboBox.DataSource = logins;
            //MessageBox.Show(data.UserVerification("has").ToString());
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<User> iden = authorization.Load();
            string login = LoginComboBox.Text;
            string password = PasswordTextBox.Text;
            User user = new User(login, password);

            if(Contains(iden, user))
            {
                MessageBox.Show("Вы вошли в систему!");
            }
            else
            {
                MessageBox.Show("Проверьте логин или пароль");
            }


            

        }
        private bool Contains(List<User> users, User user)
        {
            foreach (User u in users)
            {
                if (user.Login == u.Login && user.Password == u.Password)
                {
                    return true;
                }
            }
            return false;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            newForm.Show();
        }
    }
}
