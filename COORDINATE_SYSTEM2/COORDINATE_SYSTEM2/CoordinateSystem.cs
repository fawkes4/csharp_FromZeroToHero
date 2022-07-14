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
        List<IFigure> Figures = new List<IFigure>();

        List<PointsDistance> PointsDistances = new List<PointsDistance>();

        public void Add(IFigure figure)
        {
            Figures.Add(figure);
        }

        public void PrintAreas()
        {
            foreach (IFigure figure in Figures)
            {
                var area = figure.Area() == 0 ? "N / A" : figure.Area().ToString();
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Area is {area}\n");
            }
        }

        public void PrintPerimeter()
        {
            foreach (IFigure figure in Figures)
            {
                var perimeter = figure.Perimeter();
                var perimeterToString = perimeter == 0 ? "N / A" : perimeter.ToString();
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Perimeter is {perimeterToString}\n");
            }
        }

        public void DisplayAllPoints()
        {
            List<Point> listOfPoints = GetFiguresPoints();

            for (int i = 0; i < listOfPoints.Count; i++)
            {
                Console.WriteLine($"point {i} : {listOfPoints[i]};");
            }
        }

        List<Point> GetFiguresPoints()
        {
            List<Point> Points = new List<Point>();

            foreach (IFigure innerFigure in Figures)
            {
                Points.AddRange(innerFigure.GetPoints());
            }

            return Points;
        }

        /// <summary>
        /// метод, що рахує і друкує всі відстані. 
        /// Створюю два ліста, які набирають значень всіх існуючих точок.
        /// перший цикл бере кожен елемент з першого ліста.
        /// другий цикл йде по другому лісті, беручи кожен елемент ОКРІМ першого для пошуку відстані.
        /// Після знаходження відстані - добавляю цб відстань в ліст відстаней та
        /// КОЛИ другий ліст дійшов до свого кінця - видаляю перший елемент з ДРУГОГО ліста
        /// аби уникнути повторень.
        /// </summary>
        public void PrintAllDistances()
        {
            PointsDistances.Clear();

            List<Point> listOfPoints = GetFiguresPoints();
            List<Point> listOfPoints2 = GetFiguresPoints();

            foreach (Point point in listOfPoints)
            {
                for (int i = 1; i < listOfPoints2.Count; i++)
                {
                    int count = i;
                    Point point1 = listOfPoints2[i];
                    PointsDistance distance = new PointsDistance(point1, point);
                    PointsDistances.Add(distance);
                }
                listOfPoints2.RemoveAt(0);
            }

            for (int i = 0; i < PointsDistances.Count; i++)
            {
                Console.WriteLine($"{i} : The distance between {PointsDistances[i].Point1} and {PointsDistances[i].Point2} is {PointsDistances[i].Distance}");
            }
        }

        //public void PrintAllDistances2()
        //{
        //    List<Point> Points = GetFiguresPoints();

        //    for(int i = 0; i < Points.Count; i++)
        //    {
        //        Point point = Points[i];

        //        for(int j = 0; j < Points.Count; j++)
        //        {
        //            Point point1 = Points[j];
        //            PointsDistance distance = new PointsDistance(point, point1);
        //            PointsDistances.Add(distance);
        //        }
        //    }

        //    foreach (var item in PointsDistances)
        //    {
        //        Console.WriteLine($"The distance between {item.Point1} and {item.Point2} is {item.Distance}");
        //    }
        //}

        public PointsDistance MaxDistance()
        {
            PointsDistance pointsDistance = null;

            if (PointsDistances.Count == 0)
            {
                return null;
            }

            double max = PointsDistances[0].Distance;

            for (int i = 1; i < PointsDistances.Count; i++)
            {
                if (PointsDistances[i].Distance > max)
                {
                    max = PointsDistances[i].Distance;
                    pointsDistance = PointsDistances[i];
                }
            }

            return pointsDistance;
        }

        public PointsDistance MinDistance()
        {
            PointsDistance pointsDistance = null;

            if (PointsDistances.Count == 0)
            {
                return null;
            }

            double min = PointsDistances[0].Distance;

            for (int i = 1; i < PointsDistances.Count; i++)
            {
                if (PointsDistances[i].Distance < min)
                {
                    min = PointsDistances[i].Distance;
                    pointsDistance = PointsDistances[i];
                }
            }

            return pointsDistance;
        }
    }
}
