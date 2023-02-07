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

            string[] splitedString = input.Split(',', StringSplitOptions.TrimEntries);

            if (int.TryParse(splitedString[0], out int num1)
                && int.TryParse(splitedString[1], out int num2))
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
    }
}
