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

        List<Point> rectanglesPoints = new List<Point>();

        public Rectangle(Point point1, Point point2) //TODO чотирикутник який задаватиметься через дві точки і знаходитиме всі решта точки
        {
            Point1 = point1;
            Point2 = point2;
            Point point3 = new Point(Point1.CoordinateX, Point2.CoordinateY);
            Point point4 = new Point(Point2.CoordinateX, Point1.CoordinateY);
            rectanglesPoints.Add(point1);
            rectanglesPoints.Add(point2);
            rectanglesPoints.Add(point3);
            rectanglesPoints.Add(point4);

            Distance1 = point1.DistanceTo(point3);
            Distance2 = point2.DistanceTo(point3);
            
        }

        public Point CreatePoints()
        {
            Point point3 = new Point(Point1.CoordinateX, Point2.CoordinateY);

            return point3;
        }

        public double Area()
        {
            double area;
            area = Distance1 * Distance2;

            return area;
        }

        public double Perimeter()
        {
            double perimeter;
            perimeter = 2 * Distance1 + 2 * Distance2;

            return perimeter;
        }

        public override string ToString()
        {
            return $"(The Rectangle's points are : {Point1}, {Point2}, {rectanglesPoints[3]}, {rectanglesPoints[4]}.";
        }
    }
}
