using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class InputModule
    {
        static public (List<string>[], List<int>[]) InputCustomersByServices()
        {
            List<string>[] CustomersByServices = new List<string>[3] { new List<string>(),
                                                                new List<string>(),
                                                                new List<string>()
            };

            List<int>[] counts = new List<int>[3]{ new List<int>(),
                                                   new List<int>(),
                                                   new List<int>()
            };

            CustomersByServices[0].Add("Дима");
            counts[0].Add(10);
            CustomersByServices[0].Add("Олег");
            counts[0].Add(5);
            CustomersByServices[0].Add("Кирилл");
            counts[0].Add(1);

            CustomersByServices[1].Add("Ира");
            counts[1].Add(2);
            CustomersByServices[1].Add("Маша");
            counts[1].Add(25);

            CustomersByServices[2].Add("Катя");
            counts[2].Add(30);

            return (CustomersByServices, counts);
        }
        static public string InputUserQuery()
        {
            Console.Write("Введите, пожалуйста, услугу (Массаж/Маникюр/Педикюр): ");
            return Console.ReadLine();
        }

    }
}
