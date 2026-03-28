using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    public class User
    {
        private string login_;
        private string password_;


        public User(string login, string password)
        {
            login_ = login;
            password_ = password;
        }

        public string Login
        {
            get { return login_; }
        }

        public string Password
        {
            get { return password_; }
        }
    }
}
