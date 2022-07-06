using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    /// <summary>
    /// Клас Point. Цей клас створює точку через конструктор, 
    /// містить ToString(), 
    /// рахує відстань між двома точками DistanceTo(), 
    /// створює нову точку, що відображається відносно осі.
    /// </summary>
    internal class Point : IFigure
    {
        private int coordinateX;
        private int coordinateY;

        public Point(int coordinateX, int coordinateY)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }

        public int CoordinateX 
        { 
            get { return this.coordinateX; } 
        }

        public int CoordinateY
        {
            get { return this.coordinateY; }
        }

        public override string ToString()
        {
            return $"({coordinateX}, {coordinateY})";
        }

        public double DistanceTo(Point point)
        {
            int distBetweenX = point.CoordinateX - CoordinateX;
            int distBetweenY = point.CoordinateY - CoordinateY;

            double distanceBetwPoints = Math.Sqrt(distBetweenX * distBetweenX + distBetweenY * distBetweenY);

            return distanceBetwPoints;
        }

        public Point XAxisReflection()
        {
            Point point = new Point(CoordinateX, -CoordinateY);

            return point;
        }

        public Point YAxisReflection()
        {
            Point point = new Point(-CoordinateX, CoordinateY);

            return point;
        }
    }
}
