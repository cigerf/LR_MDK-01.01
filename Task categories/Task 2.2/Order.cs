

using System;

namespace Task_2._2
{
    public class Order
    {
        private int OrderId_;               // ID заказа
        private double TotalAmount_;       // Общая сумма
        private int Weight_;            // Вес
        private string DestinationCountry_; // Страна доставки
        private string PaymentMethod_;      // Способ оплаты

        public int GetOrderId() // получение ID
        {
            return OrderId_;
        }
        public double GetTotalAmount() // получение общей суммы
        {
            return TotalAmount_;
        }
        public int GetWeight() // получение веса
        {
            return Weight_;
        }
        public string GetDestinationCountry() // получение страны назначения
        {
            return DestinationCountry_;
        }
        public string GetPaymentMethod() // почение способа оплаты
        {
            return PaymentMethod_;
        }

        public void SetOrderId(int OrderId) // ввод ID
        {
            OrderId_ = OrderId;
        }
        public void SetTotalAmount(double TotalAmount) // ввод общей суммы
        {

            TotalAmount_ = TotalAmount;
        }
        public void SetWeight(int Weight) // ввод веса
        {
            Weight_ = Weight;
        }
        public void SetDestinationCountry(string DestinationCountry) // ввод страны назначения
        {
            DestinationCountry_ = DestinationCountry;
        }
        public void SetPaymentMethod(string PaymentMethod) // ввод метода оплаты
        {
            PaymentMethod_ = PaymentMethod;
        }

        public void ShowOrder() // вывод информации о заказе
        {
            Console.WriteLine($"Заказ номер: {OrderId_}");
            Console.WriteLine($"Сумма: {TotalAmount_} руб.");
            Console.WriteLine($"Вес: {Weight_} кг");
            Console.WriteLine($"Страна: {DestinationCountry_}");
            
            
        }


    }
}
