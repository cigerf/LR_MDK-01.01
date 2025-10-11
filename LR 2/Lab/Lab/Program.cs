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
            string[] services = new string[] { "Массаж", "Маникюр", "Педикюр" };
            var (customers, counts) = InputModule.InputCustomersByServices();
            string userQuery = InputModule.InputUserQuery();
            int indexService = SearchingModule.FindIndexServices(userQuery, services);
            if (indexService < 0)
            {
                Console.WriteLine("Указан несуществующий жанр");
                return;
            }
            var (CustomersUserServices, countsUserServices) = SearchingModule.FindAllCustomersByServices(indexService, customers, counts);
        }
    }
}
