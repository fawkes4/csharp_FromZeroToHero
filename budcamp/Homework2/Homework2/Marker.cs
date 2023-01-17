using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public struct Marker
    {
        public string Color { get; set; }
        public static int Index = 0;

        static Marker()
        {
            Index = 300;
        }

        public Marker(string color)
        {
            this.Color = color;
        }

        public void PrintMarker()
        {
            Console.WriteLine($"this market is {Color} and its index is {Index}");
        }

        public static Marker? InitMarker(string? color)
        {
            return new Marker(color);
        }
    }
}

