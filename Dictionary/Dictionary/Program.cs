using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static public void NumberElements(Dictionary<string, List<string>> magazines)
        {
            Console.WriteLine("Введите журнал:");
            string key = Console.ReadLine(); // ввод ключа
            if (magazines.ContainsKey(key))
            {
                int number = magazines[key].Count(); // Поиск числа элементов
                Console.Write(number);
            }
        }
        static void Main()
        {
            Dictionary<string, List<string>> magazines = new Dictionary<string, List<string>>(); // создал пустой словарь
            magazines.Add("Звезда", new List<string>() {"Гадание", "Шоу-бизнес"}); // Добавили ключ "Звезда" и заполнили значениями
            magazines.Add("Луна", new List<string>() {"Календарь огородникам","Программа радио"}); // аналогично с верхней
            magazines.Add("Ретроградный меркурий", new List<string>() {"Воскресенский воскрес в Воскресенье", "Гуф вернулся к жизни"}); // аналогично с верхней
            Console.WriteLine("Ключи: " +string.Join(", ", magazines.Keys));//вывод ключей 
            /*
             Console.WriteLine();
             Console.WriteLine("Введите ключ:");
             string key = Console.ReadLine(); // ввод ключа
             Console.WriteLine();
             Console.WriteLine(string.Join(", ", magazines[key])); // ввывод по введёному ключу
            */
            NumberElements(magazines);
        }
    }
}
