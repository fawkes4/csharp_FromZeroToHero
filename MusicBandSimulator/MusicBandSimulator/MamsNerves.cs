using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    internal class MamsNerves : IMusicInstrument
    {
        /// <summary>
        /// Об'єкт - мамині нерви. Наслідує клас Інструмент.
        /// </summary>
        
        public string Name { get; set; }

        //public void Sound()
        //{
        //    Console.WriteLine($"*{Name} are playing*");
        //}

        public MamsNerves()
        {
            Name = "MamsNerves";
        }

        public override string ToString()
        {
            return $"*{Name} are getting worse*";
        }
    }
}
