using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
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
    }
}
