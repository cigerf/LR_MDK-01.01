

using System;

namespace Task_2._2
{
    public class FraudChecker
    {
        static public void fraudChecker(Order order) // проверка на подозрительно крупные суммы
        {
            if (order.GetTotalAmount() > 1000000) // Больше миллиона
            {

                Console.WriteLine("ВНИМАНИЕ: Слишком большая сумма!");
                Console.WriteLine("Очень дорогой заказ!");
            }
            else if (order.GetTotalAmount() > 100000) // Больше 100 тысяч
            {
                Console.WriteLine("Заказ проверен, но сумма большая");
                Console.WriteLine("Большая сумма, но ок");
            }
            else if (order.GetTotalAmount() < 100) // Меньше 100 рублей
            {
                Console.WriteLine("Маленький заказ, все ок");
                Console.WriteLine("Маленький заказ - ок");
            }
            else
            {
                Console.WriteLine("Сумма нормальная");
                
            }
        }
    }
}
