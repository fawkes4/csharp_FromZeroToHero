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

        List<PointsDistance> listOfPointsDistances = new List<PointsDistance>();

        public void Add(IFigure figure)
        {
            listOfFigures.Add(figure);
        }

        public void PrintAreas()
        {
            foreach (IFigure figure in listOfFigures)
            {
                var area = figure.Area();
                var pishovNahyi = area == 0 ? "N / A" : area.ToString();
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Area is {pishovNahyi}\n");
            }
        }

        public void PrintPerimeter()
        {
            foreach (IFigure figure in listOfFigures)
            {
                var perimeter = figure.Perimeter();
                var pishovNahyi = perimeter == 0 ? "N / A" : perimeter.ToString();
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Perimeter is {pishovNahyi}\n");
            }
        }

        public void DisplayAllPoints()
        {
            List<Point> listOfPoints = AddAllFiguresPointsIntoList();

            for (int i = 0; i < listOfPoints.Count; i++)
            {
                Console.WriteLine($"point {i} : {listOfPoints[i]};");
            }
        }
        
        public List<Point> AddAllFiguresPointsIntoList()
        {
            List<Point> listOfPoints = new List<Point>();

            foreach (IFigure innerFigure in listOfFigures)
            {
                foreach (Point point in innerFigure.GetPoints())
                {
                    listOfPoints.Add(point);
                }
            }

            return listOfPoints;
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
            List<Point> listOfPoints = AddAllFiguresPointsIntoList();
            List<Point> listOfPoints2 = AddAllFiguresPointsIntoList();
            
            foreach(Point point in listOfPoints)
            {
                for(int i = 1; i < listOfPoints2.Count; i++)
                {
                    int count = i;
                    Point point1 = listOfPoints2[i];
                    PointsDistance distance = new PointsDistance(point1, point);
                    listOfPointsDistances.Add(distance);
                }
                listOfPoints2.RemoveAt(0);
            }

            foreach (var item in listOfPointsDistances)
            {
                Console.WriteLine($"The distance between {item.Point1} and {item.Point2} is {item.Distance}");
            }
        }
        

        public PointsDistance MaxDistance()
        {
            PointsDistance pointsDistance = null;

            if (listOfPointsDistances.Count == 0)
            {
                return null;
            }

            double max = listOfPointsDistances[0].Distance;

            for (int i = 1; i < listOfPointsDistances.Count; i++)
            {
                if (listOfPointsDistances[i].Distance > max)
                {
                    max = listOfPointsDistances[i].Distance;
                    pointsDistance = listOfPointsDistances[i];
                }
            }

            return pointsDistance;
        }

        public PointsDistance MinDistance()
        {
            PointsDistance pointsDistance = null;

            if (listOfPointsDistances.Count == 0)
            {
                return null;
            }

            double min = listOfPointsDistances[0].Distance;

            for (int i = 1; i < listOfPointsDistances.Count; i++)
            {
                if (listOfPointsDistances[i].Distance < min)
                {
                    min = listOfPointsDistances[i].Distance;
                    pointsDistance = listOfPointsDistances[i];
                }
            }

            return pointsDistance;
        }
    }
}
