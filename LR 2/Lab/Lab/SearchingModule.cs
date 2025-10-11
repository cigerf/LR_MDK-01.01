using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class SearchingModule
    {
        static public int FindIndexServices(string userQuery, string[] services)
        {
            for (int index = 0; index < services.Length; ++index)
            {
                string valueServices = services[index].ToLower();
                if (valueServices == userQuery.ToLower())
                {
                    return index;
                }
            }

            return -1;
        }
        static public (List<string>, List<int>) FindAllCustomersByServices(int indexService,
                                                             List<string>[] allService,
                                                             List<int>[] counts)
        {
            List<string> CustomersByServices = new List<string>();
            List<int> countsByServices = new List<int>();

            CustomersByServices = allService[indexService];
            countsByServices = counts[indexService];

            return (CustomersByServices, countsByServices);
        }
    }
}