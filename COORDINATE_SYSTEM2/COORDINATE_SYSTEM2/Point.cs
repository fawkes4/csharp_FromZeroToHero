using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class Point //об'єкт точка: створює точку, в якій приймає аргументами координати цієї точки. Має метод ToString який пише ці координати, DistanceTo який рахує й повертає відстань між точками, які вказуються, XAxisReflection/YAxisReflection які повертають мені ту ж точку, лиш дзеркально відбиту відносно осі.
    {
        private int x;
        private int y;

        public Point() { }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X 
        { 
            get { return this.x; } 
        }

        public int Y
        {
            get { return this.y; }
        }

        public override string ToString()
        {
            return $"{(x, y)}";
        }

        public double DistanceTo(Point point)
        {
            int dX = point.X - X; //distance Between X
            int dY = point.Y - Y; //distance Between Y

            double distanceBetwPoints = Math.Sqrt(dX * dX + dY * dY);

            return distanceBetwPoints;
        }

        public Point XAxisReflection()
        {
            Point point = new Point(X, -Y);
            return point;
        }

        public Point YAxisReflection()
        {
            Point point = new Point(-X, Y);
            return point;
        }

    }
}
