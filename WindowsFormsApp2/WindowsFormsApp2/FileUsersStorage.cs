using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class FileUsersStorage : IUserInterface
    {
        public List<User> Load()
        {
            List<User> result = new List<User>();
            StreamReader Sr = new StreamReader("Parolle.txt");
            string line;
            while ((line = Sr.ReadLine()) !=null)
            {
                string[] UserInformation = line.Split('-');
                User user = new User(UserInformation[0], UserInformation[1]);
                result.Add(user);
            }
            return result;
        }
        public bool CheckUser(string login)
        {
            List<User> users = Load();
            foreach (User element in users)
            {
                if (login == element.GetLogin())
                {
                    return true;
                }
            }
            return false;
        }
        public void AddUser(User user)
        {
            StreamWriter sw = new StreamWriter("Parolle.txt");
        }
    }
}
