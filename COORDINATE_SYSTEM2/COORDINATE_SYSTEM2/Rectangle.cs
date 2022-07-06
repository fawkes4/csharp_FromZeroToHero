using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class Rectangle : IFigure
    {
        public Point Point1 { get; }
        public Point Point2 { get; }
        public double Distance1 { get; }
        public double Distance2 { get; }

        public Rectangle(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
            CreatePoints();
            Distance1 = point1.DistanceTo(point3);
            Distance2 = point2.DistanceTo(point3);
            
        }

        public void CreatePoints()
        {
            Point point3 = new Point(Point1.CoordinateX, Point2.CoordinateY);
            Point point4 = new Point(Point2.CoordinateX, Point1.CoordinateY);
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
