using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class FileUsersStorage : IUserInterface
    {
        public List<User> Load()
        {
            List<User> result = new List<User>();
            StreamReader Sr = new StreamReader("D:\\Воск repos\\WindowsFormsApp2\\Parolle.txt");
            string line;
            while ((line = Sr.ReadLine()) !=null)
            {
                string[] UserInformation = line.Split('-');
                User user = new User(UserInformation[0], UserInformation[1]);
                result.Add(user);
            }
            return result;
        }
    }
}
