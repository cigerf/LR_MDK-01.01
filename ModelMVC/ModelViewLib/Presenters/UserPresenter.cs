using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Presenters
{
    public class UserPresenter
    {
         IUsersModel usersModel_;
         IUserView userView_;

        public UserPresenter(IUserView V, IUsersModel M)
        {
            usersModel_ = M;
            userView_ = V;
            List<User> users = M.LoadUser();
            V.ShowUsers(users);
        }
    }
}
