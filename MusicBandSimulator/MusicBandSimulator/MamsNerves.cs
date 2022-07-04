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
        /// Об'єкт - мамині нерви. Імплементує інтерфейс IMusicInstrument.
        /// </summary>

        public string Name { get; }

        public MamsNerves()
        {
            Name = "MamsNerves";
        }

        public string Sound()
        {
            return $"*{Name} are pulled like a string. BRINGGGg-BRINGGGGggg*";
        }
    }
}
