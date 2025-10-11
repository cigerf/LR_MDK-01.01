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
        }
    }
}
