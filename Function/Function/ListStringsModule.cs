using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class ListStringsModule
    {
        static public List<string> FillingListLines()
        {
            Console.WriteLine("Введите количество строк");
            int CountLines = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            for (int index = 0; index < CountLines; index++)
            {
                list.Add(Console.ReadLine());
            }
            return list;
        }
        static public List<int> ElementsNumber(List<string> list, string text)
        {
            List<int> result = new List<int>();
            for (int index = 0; index < list.Count; index++)
            {
                if (list.Contains(text))
                {
                    result.Add(index);
                }
            }
            return result;
        }
    }
}