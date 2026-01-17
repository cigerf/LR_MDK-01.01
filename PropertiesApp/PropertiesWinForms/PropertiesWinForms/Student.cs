using System;
using System.ComponentModel;

namespace PropertiesWinForms
{
    public class Student
    {
        private string name_;
        private DateTime birthDay_;
        private string number_;
        private double avgBall_;
        private int ticketNumber_;
        private double averagePoint_;

        [DisplayName("ФИО")]
        public string Name
        {
            get { return name_; }
            set { name_ = value; }
        }

        [DisplayName("Дата рождения")]
        public string BirthDay
        {
            get { return birthDay_.ToString("dd.mm.yyyy"); }
        }
        public void SetBirthDay(DateTime d)
        {
            birthDay_ = d;
        }

        [DisplayName("Номер билета")]
        public int TicketNumber
        {
            get { return ticketNumber_; }
            set { ticketNumber_ = value; }
        }

        [DisplayName("Средний балл")]
        public double AveragePoint
        {
            get { return averagePoint_; }
            set { averagePoint_ = value; }
        }
      
    }
}
