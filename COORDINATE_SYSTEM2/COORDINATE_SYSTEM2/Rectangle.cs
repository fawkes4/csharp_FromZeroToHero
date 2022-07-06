using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class Rectangle 
    {
        public Point Point1 { get; }
        public Point Point2 { get; }
        public double Distance1 { get; }
        public double Distance2 { get; }

        public Rectangle(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
            Point point3 = new Point(point1.CoordinateX, point2.CoordinateY);
            Distance1 = point1.DistanceTo(point3);
            Distance2 = point2.DistanceTo(point3);
            Point point4 = new Point(point2.CoordinateX, point1.CoordinateY);
        }

        public void Area()
        {
            double area;
            area = Distance1 * Distance2;
        }

        public void Perimeter()
        {
            double perimeter;
            perimeter = 2 * Distance1 + 2 * Distance2;
        }
    }
}
