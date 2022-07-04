using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    /// <summary>
    /// Об'єкт - скрипка. Імплементує інтерфейс IMusicInstrument.
    /// </summary>
    internal class Violin : IMusicInstrument
    {
        public string Name { get; set; }

        public Violin()
        {
            Name = "Violin";
        }

        public string Sound()
        {
            return $"*{Name} is playing*";
        }
    }
}
