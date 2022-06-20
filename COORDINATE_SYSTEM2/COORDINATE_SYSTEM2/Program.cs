using System;
using System.Collections.Generic;
using System.Linq;

namespace COORDINATE_SYSTEM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 8);
            Point p2 = new Point(9, 4);
            Point p3 = new Point(5, 10);
            Point p4 = new Point(1, 1);
            Point p5 = new Point(7, 0); // додав точки
            
            CoordinateSystem coordinateSystem = new CoordinateSystem();
            coordinateSystem.Add(p1); 
            coordinateSystem.Add(p2);
            coordinateSystem.Add(p3);
            coordinateSystem.Add(p4);
            coordinateSystem.Add(p5);
            
            coordinateSystem.DisplayAllPoints();

            coordinateSystem.FindDistance();

            coordinateSystem.MaxDistance();

            coordinateSystem.MinDistance();
        }

    }
}
