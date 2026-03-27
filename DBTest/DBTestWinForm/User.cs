using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DBTestWinForm
{
    public class User : INotifyPropertyChanged
    {
        public string login;
        public string password;
        public int age;
        public string name;
        public string lastName;

        [DisplayName("Логин")]
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        [DisplayName("Пароль")]
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        [DisplayName("Возраст")]
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }

        [DisplayName("Имя")]
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Password");
            }
        }

        [DisplayName("Фамилия")]
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
