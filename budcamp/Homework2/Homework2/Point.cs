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

            try
            {
                string[] splitedString = input.Split(',');
                splitedString[0].Trim();
                splitedString[1].Trim();

                if (int.TryParse(splitedString[0], out int num1)
                    && int.TryParse(splitedString[1], out int num2))
                {
                    num1 = (int)point.X;
                    num2 = (int)point.Y;
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
