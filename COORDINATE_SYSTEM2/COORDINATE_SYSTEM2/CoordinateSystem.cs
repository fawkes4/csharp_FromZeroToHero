using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class CoordinateSystem
    {
        List<Point> listOfPoints = new List<Point>();

        List<PointsDistance> pointsDistances = new List<PointsDistance>();

        public void Add(Point point)
        {
            foreach (Point point1 in listOfPoints)
            {
                PointsDistance distance = new PointsDistance(point, point1);
                pointsDistances.Add(distance);
            }

            listOfPoints.Add(point);
        }

        public void DisplayAllPoints()
        {
            for (int i = 0; i < listOfPoints.Count; i++)
            {
                Console.WriteLine($"point {i} : {listOfPoints[i]};");
            }
        }

        public PointsDistance MaxDistance()
        {
            PointsDistance pointsDistance = null;

            if (pointsDistances.Count == 0)
            {
                return null;
            }

            double max = pointsDistances[0].Distance;

            for (int i = 1; i < pointsDistances.Count; i++)
            {
                if (pointsDistances[i].Distance > max)
                {
                    max = pointsDistances[i].Distance;
                    pointsDistance = pointsDistances[i];
                }
            }

            return pointsDistance;
        }

        public PointsDistance MinDistance()
        {
            PointsDistance pointsDistance = null;

            if (pointsDistances.Count == 0)
            {
                return null;
            }

            double min = pointsDistances[0].Distance;

            for (int i = 1; i < pointsDistances.Count; i++)
            {
                if (pointsDistances[i].Distance < min)
                {
                    min = pointsDistances[i].Distance;
                    pointsDistance = pointsDistances[i];
                }
            }

            return pointsDistance;
        }
        
        public void PrintAllDistances()
        {
            foreach (var item in pointsDistances)
            {
                Console.WriteLine($"The distance between {item.Point1} and {item.Point2} is {item.Distance}");
            }
        }
        /*
        public PointsDistance MinDistance()
        {
            PointsDistance pointsDistance2 = pointsDistances.Min(item => item.Distance);
            return pointsDistance2;
        }*/
    }
}
