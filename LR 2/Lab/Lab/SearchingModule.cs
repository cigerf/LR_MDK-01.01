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
    }
}
