

using System;

namespace Task_1._1
{
    public class Program
    {
        static void Main()
        {
            Employee Dima = new Employee();
            Dima.SetID(1);
            Dima.SetFullName("Dima Dmitrev");
            Dima.SetEmail("Dima@mail.ru");
            Employee Darya = new Employee();
            Darya.SetID(2);
            Darya.SetFullName("Darya Dmitreva");
            Darya.SetEmail("Darya@mail.ru");
            Employee Danik = new Employee();
            Danik.SetID(3);
            Danik.SetFullName("Danik Dmitrev");
            Danik.SetEmail("Danik@mail.ru");

            FixedSalaryEmployee Dimon = new FixedSalaryEmployee();
            Dimon.SetEmployee(Dima);
            Dimon.SetFixedSalary(100000);
            Console.WriteLine("Зарплата Димона: " + Dimon.CalculateSalary() + " рублей");

            HourlySalaryEmployee Dasha = new HourlySalaryEmployee();
            Dasha.SetEmployee(Darya);
            Dasha.SetsalarPenHour(600);
            Dasha.SethoursWorked(48);
            Dasha.SetovertimeHours(52);
            Console.WriteLine("Зарплата Даши: " + Dasha.CalculateSalary() + " рублей");

            FreelancerEmployee Danya = new FreelancerEmployee();
            Danya.SetEmployee(Danik);
            Danya.SetProjectPayment(150000);
            Danya.SetTaxPercent(10);
            Console.WriteLine("Зарплата Даника: " + Danya.CalculateSalary() + " рублей");

        }
    }
}
