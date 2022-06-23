using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class PointsDistance //клас, в якому я маю конструктор, який збирає докупи інформацію про дві точки і відстань між ними
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public double Distance { get; set; }

        //public PointsDistance() { }

        public PointsDistance(Point point1, Point point2, double distance)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Distance = distance;
        }
    }
}
