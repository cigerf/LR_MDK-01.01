using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    internal class Program
    {
        static void Main()
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

            storage.GetProductQuantity();
            storage.CalculateMoney();

            Console.WriteLine();

            Report report = new Report();

            ReportRow row1 = new ReportRow();
            row1.Product = "ШЫШУЛЯ";
            row1.Quantity = 500;
            row1.Price = 100;

            ReportRow row2 = new ReportRow();
            row2.Product = "ШУШАРИКИ";
            row2.Quantity = 100;
            row2.Price = 5192;

            ReportRow row3 = new ReportRow();
            row3.Product = "Puss in boots";
            row3.Quantity = 70;
            row3.Price = 412;

            report.AddRecord(row1);
            report.AddRecord(row2);
            report.AddRecord(row3);

            report.ToString();
            Console.WriteLine();

            report.CalculateSum();
        }
    }
}
