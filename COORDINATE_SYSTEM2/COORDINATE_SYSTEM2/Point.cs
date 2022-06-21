using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class Point//:CoordinateSystem
    {
        private int x;
        private int y;

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
            double dPoints = Math.Sqrt(dX * dX + dY * dY); //distance Between Points
            return dPoints;
        }

        public Point XAxisReflection() //чоиу я не міг викликати метод 'XAxisReflection(p1)' ?
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
