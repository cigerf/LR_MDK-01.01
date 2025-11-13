using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static int AllSales(int[] price, int[] AmountSaled, DateTime[] Time)
        {
            int AllSale = 0;
            Console.WriteLine("Введите номер интересущего вас периода");
            for (int index = 0; index < price.Length; index++)
            {
                Console.WriteLine($"Период {index} - " + Time[index]);
            }
            int UserTime = Convert.ToInt32(Console.ReadLine());
            AllSale = price[UserTime] * AmountSaled[UserTime];
            return AllSale;
        }
        static void MostSaled(int[] price, int[] AmountSaled, string[] Phone)
        {
            int MaxSaledPhone = 0;
            int MinSaledPhone = 0;
            int MaxSaled = price[MaxSaledPhone] * AmountSaled[MaxSaledPhone];
            int MinSaled = price[MinSaledPhone] * AmountSaled[MinSaledPhone];
            for (int index = 0; index < AmountSaled.Length; index++)
            {
                int Sale = price[index] * AmountSaled[index];
                if (MaxSaled < Sale)
                {
                    MaxSaled = Sale;
                    MaxSaledPhone = index;
                }
            }
            for (int index = 0; index < AmountSaled.Length; index++)
            {
                
                int Sale = price[index] * AmountSaled[index];
                if (MinSaled > Sale & MinSaled!= 0)
                {
                    MinSaled = Sale;
                    MinSaledPhone = index;
                }
            }
            Console.WriteLine($"Самый продаваемый телефон - {Phone[MaxSaledPhone]}");
            Console.WriteLine("Сумма продаж - " + MaxSaled);
            Console.WriteLine();
            Console.WriteLine($"Телефон с наименьшим фактором продаж - {Phone[MinSaledPhone]}");
            Console.WriteLine("Сумма продаж - " + MinSaled);
        }
        static void Main()
        {
            string[] Phone = new string[] { "Samsung A32", "IPhone 5", "Tecno Spark", "Honor x9a5", "IPhone 6" };
            int[] Price = new int[] { 25000, 15000, 20000, 35000, 18000 };
            int[] CountSaled = new int[] { 10, 45, 9, 4, 24 };
            DateTime date1 = new DateTime(2025, 3, 11, 12, 35, 0);
            DateTime date2 = new DateTime(2025, 3, 11, 15, 0, 0);
            DateTime date3 = new DateTime(2025, 3, 12, 10, 25, 0);
            DateTime date4 = new DateTime(2025, 3, 11, 13, 45, 0);
            DateTime date5 = new DateTime(2025, 3, 11, 16, 5, 0);
            DateTime[] Time = new DateTime[] { date1, date2, date3, date4, date5 };
            int AllSaled = AllSales(Price, CountSaled, Time);
            Console.WriteLine("Общая сумма продаж за выбранный период = " + AllSaled);
            Console.WriteLine();
            MostSaled(Price, CountSaled, Phone);
        }
    }
}
