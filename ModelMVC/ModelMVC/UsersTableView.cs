using ModelViewLib.ModelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelMVC
{
    class UsersTableView : DataGridView, IUserView
    {
        public void ShowUsers(List<User> users)
        {
            DataSource = users;
        }
    }
}
