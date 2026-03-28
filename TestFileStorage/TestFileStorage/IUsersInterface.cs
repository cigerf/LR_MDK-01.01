using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    interface IUsersInterface
    {
        List<User> Load();

        bool UserVerification(string login);
        bool UserRegistration(User us);



    }

    
}