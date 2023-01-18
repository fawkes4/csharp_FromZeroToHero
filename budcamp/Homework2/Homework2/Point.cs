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

        public Point TryParsePoint(string input, out Point point)
        {
            point = default(Point);
            int num1;
            int num2;
            string[] splitedString = new string[2];
            
            splitedString = input.Split(input, ',');
            splitedString[0].Trim();
            splitedString[1].Trim();

            if (int.TryParse(splitedString[0], out num1))
            {
                point.X = num1;
            }
            else
            {
                Console.WriteLine($"Result of parsing: false, Point = undefined");
            }

            if(int.TryParse(splitedString[1], out num2))
            {
                point.Y = num2;
            }
            else
            {
                Console.WriteLine($"Result of parsing: false, Point = undefined");
            }

            Console.WriteLine($"Result of parsing: true, Point = ({point.X}, {point.Y})");
        }
    }
}
