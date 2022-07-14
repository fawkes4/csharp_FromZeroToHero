using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class Rectangle : IFigure
    {
        //public Point Point1 { get; }
        //public Point Point2 { get; }
        public double Distance1 { get; }
        public double Distance2 { get; }

        List<Point> rectanglesPoints = new List<Point>();

        public Rectangle(Point point1, Point point2) //TODO чотирикутник який задаватиметься через дві точки і знаходитиме всі решта точки
        {
            Point point3 = new Point(point1.CoordinateX, point2.CoordinateY);
            Point point4 = new Point(point2.CoordinateX, point1.CoordinateY);

            rectanglesPoints.Add(point1);
            rectanglesPoints.Add(point2);
            rectanglesPoints.Add(point3);
            rectanglesPoints.Add(point4);

            Distance1 = point1.DistanceTo(point3);
            Distance2 = point2.DistanceTo(point4);
        }

        public List<Point> GetPoints()
        {
            return rectanglesPoints;
        }

        public double Area() => Distance1 * Distance2;

        public double Perimeter()
        {
            return 2 * Distance1 + 2 * Distance2;
        }

        public override string ToString()
        {
            return $"Rectangle with points : {rectanglesPoints[0]}, {rectanglesPoints[1]}, {rectanglesPoints[2]}, {rectanglesPoints[3]}.";
        }
    }
}
