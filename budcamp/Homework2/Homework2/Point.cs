using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool TryParsePoint(string input, out Point point)
        {
            point = default(Point);
            int num1;
            int num2;
            string[] splitedString = new string[2];

            try
            {
                splitedString = input.Split(',');
                splitedString[0].Trim();
                splitedString[1].Trim();

                if (int.TryParse(splitedString[0], out num1) && int.TryParse(splitedString[1], out num2))
                {
                    point.X = num1;
                    point.Y = num2;
                }
                else
                {
                    Console.WriteLine($"Result of parsing: false, Point = undefined");
                    return false;
                }

                Console.WriteLine($"Result of parsing: true, Point = ({point.X}, {point.Y})");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("input was incorect");
                return false;
            }
        }
    }
}
