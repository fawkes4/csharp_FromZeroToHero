using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COORDINATE_SYSTEM2
{
    internal class CoordinateSystem
    {
        public List<Point> listOfPoints = new List<Point>(); //List with all Points

        public List<double> listOfDistsPoints = new List<double>(); //List with all Distances between the points

        public void Add(Point point)
        {
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

        public void FindDistance()
        {
            foreach (Point k in listOfPoints) // TODO потрібно створити якусь копію ліста, звідки видаляти член K після того, як він уже був прогнаний в циклі. Аби не дублювати ті самі відстані
            {                                 //мб замість ліста тут краще використати черги/стаки???
                foreach (Point l in listOfPoints)
                {
                    if (k == l)
                    {
                        Console.WriteLine("There were points with simillar coordinates or just one point");
                    }
                    else
                    {
                        int dX = l.X - k.X; //distance Between X
                        int dY = l.Y - k.Y; //distance Between Y
                        double dPoints = Math.Sqrt(dX * dX + dY * dY); //distance Between Points
                        listOfDistsPoints.Add(dPoints);
                        Console.WriteLine($"The distance between point {k} and {l} is : {dPoints}");
                    }
                }
            }
        }

        public void MaxDistance()
        {
            Console.WriteLine($"\nthe MAX distance is {listOfDistsPoints.Max()}");
        }

        public void MinDistance()
        {
            Console.WriteLine($"\nthe MIN distance is {listOfDistsPoints.Min()}");
        }
    }
}
