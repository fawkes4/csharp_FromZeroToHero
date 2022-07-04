using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    /// <summary>
    /// Об'єкт - піаніно. Наслідує клас Інструмент.
    /// </summary>
    internal class Piano : IMusicInstrument
    {
        public string Name { get; set; }

        //public void Sound()
        //{
        //    ToString();
        //}

        public Piano()
        {
            Name = "Piano";
        }

        public override string ToString()
        {
            return $"*{Name} is playing*";
        }
    }
}
