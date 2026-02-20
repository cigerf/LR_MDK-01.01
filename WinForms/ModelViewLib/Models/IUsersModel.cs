using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public interface IUsersModel
    {
        List<User> LoadData();
        bool RegUser(User user);
        void RemoveUsers(List<User> users);
        bool AddUser(User user);
    }
}
