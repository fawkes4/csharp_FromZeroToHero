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
        List<IFigure> figures = new List<IFigure>();

        List<PointsDistance> pointsDistances = new List<PointsDistance>();

        public void Add(IFigure figure)
        {
            figures.Add(figure);
        }

        public void PrintAreas()
        {
            foreach (IFigure figure in figures)
            {
                var area = figure.Area() == 0 ? "N / A" : figure.Area().ToString();
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Area is {area}\n");
            }
        }

        public void PrintPerimeter()
        {
            foreach (IFigure figure in figures)
            {
                var perimeter = figure.Perimeter();
                var perimeterToString = perimeter == 0 ? "N / A" : perimeter.ToString();
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Perimeter is {perimeterToString}\n");
            }
        }

        public void DisplayAllPoints()
        {
            List<Point> points = GetFiguresPoints();

            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine($"point {i} : {points[i]};");
            }
        }

        List<Point> GetFiguresPoints()
        {
            List<Point> points = new List<Point>();

            foreach (IFigure innerFigure in figures)
            {
                points.AddRange(innerFigure.GetPoints());
            }

            return points;
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
            pointsDistances.Clear();

            List<Point> Points = GetFiguresPoints();

            for (int i = 0; i < Points.Count; i++)
            {
                Point point = Points[i];

                for (int j = i + 1; j < Points.Count; j++)
                {
                    Point point1 = Points[j];
                    PointsDistance distance = new PointsDistance(point, point1);
                    pointsDistances.Add(distance);
                }
            }

            for (int i = 0; i < pointsDistances.Count; i++)
            {
                Console.WriteLine($"{i} : The distance between {pointsDistances[i].Point1} and {pointsDistances[i].Point2} is {pointsDistances[i].Distance}");
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
