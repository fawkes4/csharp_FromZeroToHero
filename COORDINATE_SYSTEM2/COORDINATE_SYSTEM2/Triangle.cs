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

        List<Point> trianglePoints = new List<Point>();

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Distance1 = point1.DistanceTo(point2);
            Distance2 = point2.DistanceTo(point3);
            Distance3 = point3.DistanceTo(point1);
        }

        public List<Point> GetPoints()
        {
            trianglePoints.Add(Point1);
            trianglePoints.Add(Point2);
            trianglePoints.Add(Point3);

            return trianglePoints;
        }

        public double Area()
        {
            double area;
            double underRoot;
            double halfPerimeter = Perimeter() / 2;
            double multiplier1 = halfPerimeter - Distance1;
            double multiplier2 = halfPerimeter - Distance2;
            double multiplier3 = halfPerimeter - Distance3;
            underRoot = halfPerimeter * multiplier1 * multiplier2 * multiplier3;
            area = Math.Sqrt(underRoot);

            return area;
        }

        public double Perimeter()
        {
            double perimeter;
            perimeter = Distance1 + Distance2 + Distance3;

            return perimeter;
        }

        public override string ToString()
        {
            return $"(The Triangle's points are : {Point1}, {Point2}, {Point3})";
        }
    }
}
