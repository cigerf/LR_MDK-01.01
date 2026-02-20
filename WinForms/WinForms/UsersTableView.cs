using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewLib.ModelViews;
using ModelViewLib.Views;

namespace WinForms
{
    public class UsersTableView : DataGridView, IUsersView
    {
        public void ShowUsers(List<User> users)
        {
            DataSource = null;
            DataSource = users;
        }
        public List<User> GetSelectedUsers() 
        {
            List<User> result = new List<User>();
            foreach(DataGridViewRow row in SelectedRows) 
            {
                result.Add(row.DataBoundItem as User);
            }
            return result;
        }
    }
}
