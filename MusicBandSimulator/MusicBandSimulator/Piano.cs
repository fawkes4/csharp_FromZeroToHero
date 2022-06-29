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
    internal class Piano : Instrument
    {
        public Piano()
        {
            InstrumentName = "Piano";
            InstrumentPlays = "*Piano is playing*";
        }
    }
}
