using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("пр");
            list.Add("боба");
            list.Add("Кирилл");
            list.Add("Богдан");
            list.Add("Дмитрий");

            Console.WriteLine("Введите ваше крутое словечко");
            string input = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ваше крутое слово " + input);

            List<string> spisok = new List<string>();
            foreach (string element in spisok)
            {
                element.Contains("пр");
                Console.Write(element);
            }
        }
    }
}
