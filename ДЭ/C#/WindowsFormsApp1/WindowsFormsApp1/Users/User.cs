using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Класс пользователя с поддержкой уведомлений об изменениях свойств
    public class User : INotifyPropertyChanged
    {
        public string login;
        public string password;
        public string role;
        public string fullname;

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

        [DisplayName("Роль")]
        public string Role
        {
            get { return role; }
            set
            {
                role = value;
                OnPropertyChanged("Role");
            }
        }

        [DisplayName("ФИО")]
        public string FullName
        {
            get { return fullname; }
            set
            {
                fullname = value;
                OnPropertyChanged("Password");
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