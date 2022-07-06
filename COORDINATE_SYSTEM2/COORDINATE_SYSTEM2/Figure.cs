using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class Figure
    {
        protected Point Point1 { get; }
        protected Point Point2 { get; }
        protected Point Point3 { get; }
        protected double Distance1 { get; }
        protected double Distance2 { get; }
        protected double Distance3 { get; }

        public Figure (Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }
    }
}
