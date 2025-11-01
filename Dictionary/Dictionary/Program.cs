
using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void NumberElements(Dictionary<string, List<string>> magazines)
        {
            Console.WriteLine("Введите интересующий вас журнал: ");
            string UserMagazine = Console.ReadLine();
            foreach (string magazine in magazines.Keys)
            { 
                string ManagizeName = magazine.ToLower();
                if (UserMagazine.ToLower() == ManagizeName)
                {
                    int UserMagazineCount = magazines[magazine].Count;
                    Console.WriteLine($"В журнале {UserMagazineCount} статьи");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("такого журнала нету");
                    Console.WriteLine();
                }
            }
            return;
        }
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> magazines = new Dictionary<string, List<string>>(); // создал пустой словарь
            magazines.Add("Звезда", new List<string>() { "Гадание", "Шоу-бизнес" }); // Добавили ключ "Звезда" и заполнили значениями
            magazines.Add("Луна", new List<string>() { "Календарь огородникам", "Программа радио" }); // аналогично с верхней
            magazines.Add("Ретроградный меркурий", new List<string>() { "Воскресенский воскрес в Воскресенье", "Гуф вернулся к жизни" }); // аналогично с верхней
            Console.WriteLine("Ключи: " + string.Join(", ", magazines.Keys));//вывод ключей 
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
