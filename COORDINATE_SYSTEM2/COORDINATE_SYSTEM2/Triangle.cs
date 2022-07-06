using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class Triangle : IFigure 
    {

        Point Point1 { get; }
        Point Point2 { get; }
        Point Point3 { get; }
        public double Distance1 { get; }
        public double Distance2 { get; }
        public double Distance3 { get; }

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Distance1 = point1.DistanceTo(point2);
            Distance2 = point2.DistanceTo(point3);
            Distance1 = point3.DistanceTo(point1);
        }

        public void Area()
        {
            double area;
            double underRoot;
            double halfPerimeter = Perimeter() / 2;
            double multiplier1 = halfPerimeter - Distance1;
            double multiplier2 = halfPerimeter - Distance2;
            double multiplier3 = halfPerimeter - Distance3;
            underRoot = halfPerimeter * multiplier1 * multiplier2 * multiplier3;
            area = Math.Sqrt(underRoot);
        }

        public double Perimeter()
        {
            double perimeter;
            perimeter = Distance1 + Distance2 + Distance3;
            return perimeter;
        }
    }
}
