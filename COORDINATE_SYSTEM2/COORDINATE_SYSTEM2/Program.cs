using System;
using System.Collections.Generic;
using System.Linq;

namespace COORDINATE_SYSTEM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoordinateSystem coordinateSystem = new CoordinateSystem();

            Point p1 = new Point(3, 8);
            Point p2 = new Point(9, 4);
            Point p3 = new Point(5, 10);
            Point p4 = new Point(1, 1);
            Point p5 = new Point(7, 0);
            
            coordinateSystem.Add(p1); 
            coordinateSystem.Add(p2);
            coordinateSystem.Add(p3);
            coordinateSystem.Add(p4);
            coordinateSystem.Add(p5);

            Console.WriteLine("CHECKING!!!!!!!!!!!!!1111111111");
            Console.WriteLine(p1.XAxisReflection()); 
            Console.WriteLine(p1.DistanceTo(p2));

            //PointsDistance pointsDistance = new PointsDistance(p1, p2, p1.DistanceTo(p2));
            //PointsDistance pointsDistance2 = new PointsDistance(p2, p3, p2.DistanceTo(p3));

            //pointsDistance.Add(pointsDistance);
            //pointsDistance2.Add(pointsDistance2);

            coordinateSystem.DisplayAllPoints();

            coordinateSystem.PrintAllDistances();

            //coordinateSystem.FindDistance();

            coordinateSystem.MaxDistance();

            coordinateSystem.MinDistance();
        }

    }
}
