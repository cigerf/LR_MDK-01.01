using System;

namespace StructProject
{
    public struct Point
    {
        public int X;
        public int Y;
        public string Name;

        static public double CalcLenVector(Point begin, Point end)
        {
            int diffX = (int)Math.Pow(end.X - begin.X, 2);
            int diffY = (int)Math.Pow(end.Y - begin.Y, 2);

            int diff = diffX + diffY;

            double lenVector = Math.Sqrt(diff);

            return lenVector;
        }
    }
}
