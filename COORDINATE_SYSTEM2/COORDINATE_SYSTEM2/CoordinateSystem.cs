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
        IFigure Figure { get; }

        List<Point> listOfPoints = new List<Point>();

        List<IFigure> listOfFigures = new List<IFigure>();

        List<PointsDistance> pointsDistances = new List<PointsDistance>();

        List<Rectangle> listOfRectangles = new List<Rectangle>();

        List<Triangle> listOfTriangles = new List<Triangle>();

        public void Add(IFigure figure) //TODO мені потрібно зробити клас/інтерфейс "ФГУРА"
                                     //- який буде базовим для Точки, Прямокутника та Трикутника.
                                     //І в методі Ед приймати їх через цей базовий клас.
        {
            if(figure is Point)
            {
                foreach (Point point1 in listOfPoints)
                {
                    PointsDistance distance = new PointsDistance((Point)figure, point1);
                    pointsDistances.Add(distance);
                }

                listOfPoints.Add((Point)figure);
            }
            //TODO якщо це чотирикутник.
            //я повинен пройтися по кожній з його точок почергово і знайти відстані між уже існуючими точками до кожної нової точки.
            //цикл по точках прямокутника, який братиме першу точку прямокутника і тоді запускатиме з нею цикл по всіх уже існучих точках.
            if(figure is Rectangle)
            {
                foreach (Rectangle rectangle in listOfRectangles)
                {

                    PointsDistance distance = new PointsDistance((Point)figure, point1);
                    pointsDistances.Add(distance);
                }

                listOfPoints.Add((Point)figure);
            }
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
    }
}
