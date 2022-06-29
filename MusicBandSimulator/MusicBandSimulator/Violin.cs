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
    internal class Violin : Instrument
    {
        public Violin()
        {
            InstrumentName = "Violin";
            InstrumentPlays = "*Violin is playing*";
        }
    }
}
