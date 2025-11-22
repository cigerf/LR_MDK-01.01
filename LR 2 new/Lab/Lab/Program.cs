using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        static void Main()
        {
            List<supply> supplies = new List<supply>();
            supplies.Add(new supply() { Supplier = "Фиксики", Detail = "Болты", Amount= 200 });
            supplies.Add(new supply() { Supplier = "Фиксики", Detail = "Гайки", Amount = 350 });
            supplies.Add(new supply() { Supplier = "Фиксики", Detail = "Винтики", Amount = 250 });

            supplies.Add(new supply() { Supplier = "Томас", Detail = "Колёса", Amount = 200 });
            supplies.Add(new supply() { Supplier = "Томас", Detail = "Рама", Amount = 50 });
            supplies.Add(new supply() { Supplier = "Томас", Detail = "Тормозная система", Amount = 50 });
        }
    }
}
