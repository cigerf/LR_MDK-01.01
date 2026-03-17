using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBd
{
    public class User
    {
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("Фамилия")]
        public string Last_name { get; set; }
        [DisplayName("Возраст")]
        public int Age { get; set; }
    }
}
