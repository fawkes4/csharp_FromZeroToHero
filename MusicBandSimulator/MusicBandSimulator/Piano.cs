using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    /// <summary>
    /// Об'єкт - піаніно. Імплементує інтерфейс IMusicInstrument.
    /// </summary>
    internal class Piano : IMusicInstrument
    {
        public string Name { get; }

        public Piano()
        {
            Name = "Piano";
        }

        public string Sound()
        {
            return $"*{Name} is playing*";
        }
    }
}
