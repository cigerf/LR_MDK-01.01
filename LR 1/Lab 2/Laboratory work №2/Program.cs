using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work__2
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = new int[1500];
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = rnd.Next(1, 201);
                Console.Write($"{numbers[index]} ");
            }
            int Number = 0;
        }
    }
}
