using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    /// <summary>
    /// Клас PointsDistance.
    /// Містить конструктор, який рахує відстань між двома точками.
    /// </summary>
    internal class PointsDistance
    {
        public Point Point1 { get; }
        public Point Point2 { get; }
        public double Distance { get; }

        public PointsDistance(Point point1, Point point2)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Distance = this.Point1.DistanceTo(this.Point2);
        }

        public override string ToString()
        {
            return $"(The distance between {Point1} and {Point2} is {Distance})";
        }
    }
}
