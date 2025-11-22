using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race
{
    internal class Program
    {
        static public void PrintModel(Car car)
        {
            Console.WriteLine(car.GetModel());
        }
        static public void LadaVsMers(List<Car> cars)
        {
            int time = 0;
            int finish = 220;
            while (true)
            {

                foreach (Car car in cars)
                {
                    int NumberSpace = car.GetSpeed() / 50 * time;
                    for (int i = 0; i < NumberSpace; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(car.GetModel());
                    Console.WriteLine();
                    if (NumberSpace> finish)
                    {
                        Console.Clear();
                        Console.WriteLine("Победитель - "  + car.GetModel());
                        return;
                    }
                    Console.WriteLine("============================================================================================================================================================================================================================================");
                }
                time++;
                
                Thread.Sleep(500);
                Console.Clear();
            }
        }
        static void Main()
        {
            Car Car = new Car();
            Car.SetModel("Лада");
            Car.SetSpeed(150);
            //PrintModel(Car);

            Car SecondCar = new Car();
            SecondCar.SetModel("Мерс");
            SecondCar.SetSpeed(1000);
            //PrintModel(SecondCar);

            Car ThirdCar = new Car();
            ThirdCar.SetModel("Мерс2");
            ThirdCar.SetSpeed(700);

            Car FourthCar = new Car();
            FourthCar.SetModel("Мерс3");
            FourthCar.SetSpeed(1500);

            Car FifthCar = new Car();
            FifthCar.SetModel("лада2");
            FifthCar.SetSpeed(200);

            List<Car> ListCars = new List<Car>();
            ListCars.Add(Car);
            ListCars.Add(SecondCar);
            ListCars.Add(ThirdCar);
            ListCars.Add(FourthCar);
            ListCars.Add(FifthCar);

            LadaVsMers(ListCars);
        }
    }
}
