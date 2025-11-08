using System;
using System.Threading;

namespace StructProject
{
    class Program
    {
        static void Main()
        {
            Point beginVector = new Point();
            beginVector.X = 0;
            beginVector.Y = 0;
            beginVector.Name = "Начало вектора";

            Point endVector = new Point();
            endVector.X = 0;
            endVector.Y = 55;
            endVector.Name = "Конец вектора";

            Console.WriteLine($"{beginVector.Name}:({beginVector.X}, {beginVector.Y})" +
                              $" | {endVector.Name}:({endVector.X}, {endVector.Y})");

            Console.WriteLine("Длина вектора = " + Point.CalcLenVector(beginVector, endVector));

            Vector vector = new Vector();
            vector.begin = beginVector;
            vector.end = endVector;

            Vector[] allVectors = new Vector[10]; /// массив из 10 векторов
            Random random = new Random();
            for (int i = 0; i < allVectors.Length; i++)
            {
                Vector v = new Vector(); /// по умолчанию будем создавать нулевой вектор
                v.begin.X = random.Next(-50, 51);
                v.begin.Y = random.Next(-50, 51);
                v.end.X = random.Next(-50, 51);
                v.end.Y = random.Next(-50, 51);
                v.begin.Name = "Начало вектора " + i;
                v.end.Name = "Конец вектора " + i;

                allVectors[i] = v; /// положим (разместим) вектор в соответствующей ячейке массива

                Console.WriteLine($"{v.begin.Name}:({v.begin.X}, {v.begin.Y})" +
                  $" | {v.end.Name}:({v.end.X}, {v.end.Y})");

                Thread.Sleep(2000);
            }

            Console.WriteLine("Длина 5 вектора = " 
                + Point.CalcLenVector(allVectors[4].begin, allVectors[4].end));

        }
    }
}
