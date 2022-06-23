using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class CoordinateSystem //координатна система: містить Ліст, який зберігає всі точки, метод Add, який вносить ці точки в ліст, DisplayAllPoints, який друкує всі наявні точки
    {
        List<Point> listOfPoints = new List<Point>();
        List<PointsDistance> pointsDistances = new List<PointsDistance>();

        //Point pointClass = new Point();

        public void Add(Point point)
        {
            foreach (Point point1 in listOfPoints)
            {
                //Point point2 = point;
                PointsDistance distance = new PointsDistance(point, point1, point.DistanceTo(point1));
                pointsDistances.Add(distance);
            }
            listOfPoints.Add(point);
        }

        public void DisplayAllPoints()
        {
            int count = 1;

            foreach (Point i in listOfPoints)
            {
                Console.Write($"point {count++} : {i};\n");
            }
        }

        public PointsDistance MaxDistance()
        {
            PointsDistance pointsDistance2 = null;

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
                    pointsDistance2 = pointsDistances[i];
                }
            }

            return pointsDistance2;
        }

        public PointsDistance MinDistance()
        {
            PointsDistance pointsDistance2 = null;

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
                    pointsDistance2 = pointsDistances[i];
                }
            }

            return pointsDistance2;
        }
        /*
        public PointsDistance MinDistance()
        {
            PointsDistance pointsDistance2 = pointsDistances.Min(item => item.Distance);
            return pointsDistance2;
        }*/

        public void PrintAllDistances()
        {
            for (int i = 0; i < pointsDistances.Count; i++)
            {
                Console.WriteLine($"The distance between {pointsDistances[i].Point1} and {pointsDistances[i].Point2} is {pointsDistances[i].Distance}");
            }
        }
    }
}
