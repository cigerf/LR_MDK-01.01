using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product mers = new Product();
            mers.SetName("Мерседес");
            mers.SetPrice(1000000);

            Product yaz = new Product();
            yaz.SetName("Уазик");
            yaz.SetPrice(10000000);

            Storage storage = new Storage();
            storage.SetId(123);
            storage.SetLocation("Торжок, Ул. Студенческая 3");
            storage.SetProductQuantity(mers, 2);
            storage.SetProductQuantity(yaz, 5);


        }
    }
}
