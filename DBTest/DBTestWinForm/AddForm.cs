using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public partial class AddForm : Form
    {
        PgUsersLoader loader_;
        public AddForm(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text) 
                || string.IsNullOrWhiteSpace(NameTextBox.Text)) 
            {
                MessageBox.Show("Не все обязательные поля были заполнены!", "Внимание");
                return;
            }
            if(AgeNumericUpDown.Value <= 0) 
            {
                MessageBox.Show("Возраст не может быть меньше 0");
                return;
            }
            User user = new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Age = (int)AgeNumericUpDown.Value,
                Name = NameTextBox.Text,
                LastName = LastNameTextBox.Text,
            };
            loader_.AddUser(user);
            this.Close();
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Age = (int)AgeNumericUpDown.Value,
                Name = NameTextBox.Text,
                LastName = LastNameTextBox.Text,
            };
            loader_.AddUser(user);
        }
        /*private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

            AcceptButton.Enabled = true;

        }*/
    }
}
