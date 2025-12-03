

using System;

namespace Task_2._2
{
    class Program
    {
        static void Main()
        {
            Order worker1 = new Order();
            worker1.SetOrderId(111);
            worker1.SetTotalAmount(100000);
            worker1.SetWeight(13);
            worker1.SetDestinationCountry("Россия");
            worker1.SetPaymentMethod("Карта");
            StockValidationHandler.WarehousInspection(worker1);
            FraudChecker.fraudChecker(worker1);
            DeliveryCalculator.deliveryCalculator(worker1);
            PaymentHandler.DoWork(worker1);
            Console.WriteLine();

            Order worker2 = new Order();
            worker2.SetOrderId(222);
            worker2.SetTotalAmount(110000);
            worker2.SetWeight(14);
            worker2.SetDestinationCountry("Беларусь");
            worker2.SetPaymentMethod("Агуша");
            StockValidationHandler.WarehousInspection(worker2);
            FraudChecker.fraudChecker(worker2);
            DeliveryCalculator.deliveryCalculator(worker2);
            PaymentHandler.DoWork(worker2);
        }
    }
}
