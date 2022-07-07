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
        List<Point> listOfPoints = new List<Point>();

        List<Rectangle> listOfRectangles = new List<Rectangle>();

        List<Triangle> listOfTriangles = new List<Triangle>();

        List<IFigure> listOfFigures = new List<IFigure>();

        List<PointsDistance> pointsDistances = new List<PointsDistance>();

        //TODO мені потрібно зробити КЛАС!!! "ФІГУРА"
        //- який буде базовим для Точки, Прямокутника та Трикутника.
        //І в методі Ед приймати їх через цей базовий клас.
        public void Add(IFigure figure) 
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
            else if(figure is Rectangle)
            {
                listOfRectangles.Add((Rectangle)figure);
            }
            else if(figure is Triangle)
            {
                listOfTriangles.Add((Triangle)figure);
            }
        }

        public void PrintAreas(IFigure figure)
        {
            if (figure is Point)
            {
                Console.WriteLine("N/A");
            }
            else if (figure is Rectangle)
            {
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Area is {figure.Area()}");
            }
            else if (figure is Triangle)
            {
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Area is {figure.Area()}");
            }
        }

        public void PrintPerimeter(IFigure figure)
        {
            if (figure is Point)
            {
                Console.WriteLine("N/A");
            }
            else if (figure is Rectangle)
            {
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Area is {figure.Perimeter()}");
            }
            else if (figure is Triangle)
            {
                Console.WriteLine(figure.ToString());
                Console.WriteLine($"Area is {figure.Perimeter()}");
            }
        }

        public void DisplayAllPoints()
        {
            for (int i = 0; i < listOfPoints.Count; i++)
            {
                Console.WriteLine($"point {i} : {listOfPoints[i]};");
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
