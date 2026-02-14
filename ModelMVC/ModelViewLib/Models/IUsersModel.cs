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
        List<User> LoadUser();
        bool Registration(User user);
    }
}
