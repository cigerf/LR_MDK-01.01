using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static void Main()
        {
            List<string> value = ListStringsModule.FillingListLines();
            Console.WriteLine();
            Console.WriteLine("Размер списка: " + value.Count);
            Console.WriteLine("последний элемент списка: " +value[value.Count - 1]);
        }
    }
}
