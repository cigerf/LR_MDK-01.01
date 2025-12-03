

using System;

namespace Task_2._2
{
    class PaymentHandler
    {
         static public void DoWork(Order order) // проверка метода оплаты
        {
            if (order.GetPaymentMethod() == "Карта")
            {
                Console.WriteLine("Оплата картой");
            }
            else if (order.GetPaymentMethod() == "Наличные")
            {
                Console.WriteLine("Оплата наличными при получении");
            }
            else if (order.GetPaymentMethod() == "Кошелек")
            {
                Console.WriteLine("Оплата электронным кошельком");
            }
            else
            {
                Console.WriteLine($"Неизвестный способ: {order.GetPaymentMethod()}");
            }
        }
    }
}
