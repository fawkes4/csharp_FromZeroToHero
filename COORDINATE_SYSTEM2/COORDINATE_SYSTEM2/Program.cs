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
            Point p6 = new Point(8, 11);
            Point p7 = new Point(2, 4);
            Point p8 = new Point(0, -4);
            Point p9 = new Point(8, 1);
            Point p10 = new Point(0, 1);
            Point p11 = new Point(1, 2);
            Point p12 = new Point(3, 1);

            Rectangle rectangle1  = new Rectangle(p6, p7);
            Rectangle rectangle2  = new Rectangle(p8, p9);

            Triangle triangle1 = new Triangle(p10, p11, p12);
            
            coordinateSystem.Add(p1);
            coordinateSystem.Add(p2);
            coordinateSystem.Add(p3);
            coordinateSystem.Add(p4);
            coordinateSystem.Add(p5);

            coordinateSystem.Add(rectangle1);
            coordinateSystem.Add(rectangle2);

            coordinateSystem.Add(triangle1);

            Console.WriteLine(p1.XAxisReflection()); 
            Console.WriteLine(p1.DistanceTo(p2));

            Console.WriteLine("SEARCHING!!!!!");
            coordinateSystem.DisplayAllPoints();

            coordinateSystem.PrintAllDistances();

            var maxDistance = coordinateSystem.MaxDistance();
            Console.WriteLine($"the max distance is : {maxDistance}");

            var minDistance = coordinateSystem.MinDistance();
            Console.WriteLine($"the min distance is : {minDistance}");

            coordinateSystem.MinDistance();

            Console.WriteLine("AREASSSS!!!");
            coordinateSystem.PrintAreas();
        }

    }
}
