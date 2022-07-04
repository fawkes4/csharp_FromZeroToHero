using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    /// <summary>
    /// Об'єкт - скрипка. Наслідує клас Інструмент.
    /// </summary>
    internal class Violin : IMusicInstrument
    {
        public string Name { get; set; }

        //public void Sound()
        //{
        //    Console.WriteLine($"*{Name} is playing*");
        //}

        public Violin()
        {
            Name = "Violin";
        }

        public override string ToString()
        {
            return $"*{Name} is playing*";
        }
    }
}
