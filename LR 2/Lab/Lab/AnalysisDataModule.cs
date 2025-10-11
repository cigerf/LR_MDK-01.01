using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class AnalysisDataModule
    {
        static public void SortCustomers(List<string> Customers, List<int> counts)
        {
            for (int i = 0; i < counts.Count; ++i)
            {
                for (int j = 0; j < counts.Count - 1; ++j)
                {
                    bool condition = counts[j + 1] > counts[j];
                    if (condition)
                    {
                        int temp_counts = counts[j];
                        counts[j] = counts[j + 1];
                        counts[j + 1] = temp_counts;

                        string temp_Customers = Customers[j];
                        Customers[j] = Customers[j + 1];
                        Customers[j + 1] = temp_Customers;
                    }
                }
            }
        }
    }
}
