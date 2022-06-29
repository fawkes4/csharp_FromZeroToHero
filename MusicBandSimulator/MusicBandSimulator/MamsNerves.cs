using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    internal class MamsNerves : Instrument
    {
        /// <summary>
        /// Об'єкт - мамині нерви. Наслідує клас Інструмент.
        /// </summary>
        public MamsNerves()
        {
            InstrumentName = "MamsNerves";
            InstrumentPlays = "*MamsNerves can not stand*";
        }
    }
}
