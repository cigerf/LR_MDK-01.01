using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public class MemoryUserModel : IUsersModel
    {
        List<User> users = new List<User>();
        public List<User> LoadUser()
        {
            return users;
        }

        public bool Registration(User user)
        {
            int CountLenght = users.Count();
            users.Add(user);
            return CountLenght < users.Count();
        }
        public MemoryUserModel()
        {
            users.Add(new User("шышка", "123", "Дмитрий"));
            users.Add(new User("qwerty", "228", "Алексей"));
        }
    }
}
