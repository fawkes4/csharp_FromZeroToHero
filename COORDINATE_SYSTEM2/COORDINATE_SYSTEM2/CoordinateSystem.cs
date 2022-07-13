using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    /// <summary>
    /// Клас Координатна система.
    /// Містить Ліст всіх створених точок та Ліст всіх знайдених дистанцій.
    /// Містить Add(), який створює нову точку, добавляє її в Ліст, шукає відстані 
    /// між існуючими точками до нової точки і добавляє їх в ліст.
    /// Містить DisplayAllPoints(), який друкує всі точки з ліста.
    /// Містить MaxDistance() для пошуку максимальної відстані між точками.
    /// Містить PrintAllDistances(), який друкує всі наявні відстані з Ліста.
    /// </summary>
    internal class CoordinateSystem
    {
        List<IFigure> listOfFigures = new List<IFigure>();

        List<PointsDistance> pointsDistances = new List<PointsDistance>();

        //TODO мені потрібно зробити КЛАС!!! "ФІГУРА"
        //- який буде базовим для Точки, Прямокутника та Трикутника.
        //І в методі Ед приймати їх через цей базовий клас.
        public void Add(IFigure figure) 
        {
            if(figure.Area() == 0)
            {
                foreach (Point point1 in listOfFigures)
                {
                    PointsDistance distance = new PointsDistance((Point)figure, point1);
                    pointsDistances.Add(distance);
                }

                listOfFigures.Add((Point)figure);
            }
            else if(figure.Area() != 0)
            {
                foreach (IFigure figure1 in listOfFigures)
                {
                    if(figure1.Area() != 0)
                    {
                        foreach (Point point in figure1.GetPoints())
                        {
                            foreach (Point point1 in figure.GetPoints())
                            {
                                PointsDistance distance = new PointsDistance(point1, point);
                                pointsDistances.Add(distance);
                            }
                        }
                    }
                    else if(figure1.Area() == 0)
                    {
                        Point point = figure1 as Point;
                        foreach (Point point1 in figure.GetPoints())
                        {
                            PointsDistance distance = new PointsDistance(point1, point);
                            pointsDistances.Add(distance);
                        }
                    }
                    
                }
                listOfFigures.Add(figure);
            }
        }

        public void PrintAreas()
        {
            foreach(IFigure figure in listOfFigures)
            {
                if (figure.Area() == 0)
                {
                    Console.WriteLine("N/A");
                }
                else if (figure.Area() != 0)
                {
                    Console.WriteLine(figure.ToString());
                    Console.WriteLine($"Area is {figure.Area()}");
                }
            }
        }

        public void PrintPerimeter()
        {
            foreach (IFigure figure in listOfFigures)
            {
                if (figure.Area() == 0)
                {
                    Console.WriteLine("N/A");
                }
                else if (figure.Area() != 0)
                {
                    Console.WriteLine(figure.ToString());
                    Console.WriteLine($"Area is {figure.Perimeter()}");
                }
            }
            
        }

        public void DisplayAllPoints() // чи буде проблема з методом, коли замінив Ліст?
        {
            for (int i = 0; i < listOfFigures.Count; i++)
            {
                Console.WriteLine($"point {i} : {listOfFigures[i]};");
            }
        }

        public void PrintAllDistances()
        {
            foreach (var item in pointsDistances)
            {
                Console.WriteLine($"The distance between {item.Point1} and {item.Point2} is {item.Distance}");
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
    }
}
