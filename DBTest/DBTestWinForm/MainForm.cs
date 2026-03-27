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


namespace DBTestWinForm
{
    public partial class MainForm: Form
    {
         PgUsersLoader loader = new PgUsersLoader();
        

        public MainForm()
        {                                              
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingList<User> users = loader.Load();
            dataGridView.DataSource = users;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                User user = row.DataBoundItem as User;
                loader.DeleteSelectedUser(user.Login);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить все записи?", "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                loader.ClearAllUsers();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddForm AddForm = new AddForm(loader);
            AddForm.Show();
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            User selectedUser = row.DataBoundItem as User;
            AddForm AddEditForm = new AddForm(loader);
            AddEditForm.SetUser(selectedUser);
            AddEditForm.Show();
           
        }
    }
}
