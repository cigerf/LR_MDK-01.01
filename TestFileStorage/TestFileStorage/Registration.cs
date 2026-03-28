using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class Registration: Form
    {
        private UsersDataBase registration = new UsersDataBase();
        
        public Registration()
        {
            InitializeComponent();

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            User user = new User(login, password);
            if (password == null)
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }

            if (registration.UserVerification(login))
            {
                MessageBox.Show("Такой пользователь уже существует");
            }
            else
            {
                if (registration.UserRegistration(user))
                {
                    MessageBox.Show("Вы успешно зарегистрировались");
                }
            }
        }
        
    }
}
