using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    /// <summary>
    /// Базовий клас для всіх інструментів. Містить метод ToString що дозволяє написати як грає інструмент та як звучить. Наслідує інтерфейс IMusicInstrument
    /// </summary>
    internal class Instrument : IMusicInstrument
    {
        public string InstrumentName { get; set; }
        public string InstrumentPlays { get; set; }

        public override string ToString()
        {
            return $"{InstrumentName} and we hear {InstrumentPlays}";
        }
    }
}
