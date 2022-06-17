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
            
            List<Point> listOfPoints = new List<Point>();
            listOfPoints.Add(p1);
            listOfPoints.Add(p2);
            listOfPoints.Add(p3);
            listOfPoints.Add(p4);
            listOfPoints.Add(p5); //створив List в який запхав додані точки

            Console.WriteLine($"the p1 point has coordinates : {p1.X}, {p1.Y}");
            Console.WriteLine($"the p2 point has coordinates : {p2.X}, {p2.Y}");
            Console.WriteLine($"the p3 point has coordinates : {p3.X}, {p3.Y}");
            Console.WriteLine($"the p4 point has coordinates : {p4.X}, {p4.Y}");
            Console.WriteLine($"the p5 point has coordinates : {p5.X}, {p5.Y}");

            int dX = p2.X - p1.X; //distance Between X
            int dY = p2.Y - p1.Y; //distance Between Y
            double dPoints = Math.Sqrt(dX * dX + dY * dY); //distance Between Points
            Console.WriteLine($"distance between p1 and p2 is {dPoints}");

            List<double> listOfDistsPoints = new List<double>(); //list Of Distances Between Points
            listOfDistsPoints.Add(dPoints);

            Console.WriteLine($"the first item in the list Of Distances Between Points is {listOfDistsPoints[0]} ");
            //int maxDist = int.MaxValue(listOfDistsPoints);  
            //double maxDist = listOfDistsPoints.Max();
            Console.WriteLine($"The Max value of dist in array is {listOfDistsPoints.Max()}");
            Console.WriteLine($"The Max value of dist in array is {listOfDistsPoints.Min()}");

            //string writeItself = Point.ToString();
        }

    }
}
