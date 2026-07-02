using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Delivery_Points;
using WindowsFormsApp1.Orders;

namespace WindowsFormsApp1.Users
{
    // Форма для добавления нового пользователя
    public partial class AddUsers : Form
    {
        // Загрузчик пользователей для работы с базой данных
        PgUserLoader userloader_;
        // Конструктор формы добавления пользователя
        public AddUsers(PgUserLoader loader)
        {
            InitializeComponent();
            userloader_ = loader;
        }
        // Метод для заполнения полей формы данными существующего пользователя
        public void SetUser(User user)
        {
            RoleTextBox.Text = user.role;
            FullNameTextBox.Text = user.fullname;
            LoginTextBox.Text = user.login;
            PasswordTextBox.Text = user.password;
        }

        // Обработчик кнопки "Отмена"
        private void CanselButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обработчик кнопки "Добавить пользователя"
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text)
                || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Не все обязательные поля были заполнены!", "Внимание");
                return;
            }
            User user = new User
            {
                Role = RoleTextBox.Text,
                FullName = FullNameTextBox.Text,
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
            };
            userloader_.AddUser(user);
        }
    }
}
