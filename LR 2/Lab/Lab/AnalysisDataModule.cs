using System.Collections.Generic;
using System.Security;

namespace ConsoleApp1
{
    public class AnalysisDataModule
    {
        static public void Sortcustomers(List<string> customers, List<int> counts)
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

                        string temp_customers = customers[j];
                        customers[j] = customers[j + 1];
                        customers[j + 1] = temp_customers;
                    }
                }
            }
        }

        static public double CalculateAverage(List<int> counts)
        {
            int sum = 0;
            foreach (int count in counts)
            {
                sum += count;
            }

            return sum / counts.Count;
        }
    }
}