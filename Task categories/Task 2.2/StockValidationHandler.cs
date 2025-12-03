

using System;

namespace Task_2._2
{
    public class StockValidationHandler
    {
        static public void WarehousInspection(Order order) // проверка веса
        {
            if (order.GetWeight() <= 0)
            {
                
                Console.WriteLine("Ошибка: вес не может быть 0 или меньше!");
                Console.WriteLine("Проблема: вес неверный");
            }
            else if (order.GetWeight() > 50)
            {
                
                Console.WriteLine("Ошибка: слишком тяжелый заказ!");
                Console.WriteLine("Проблема: очень тяжелый");
            }
            else
            {
                Console.WriteLine("Товары есть на складе!");
            }
        }

    }
}
