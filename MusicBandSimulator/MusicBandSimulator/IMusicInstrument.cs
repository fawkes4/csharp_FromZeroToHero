using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    /// <summary>
    /// Інтерфейс, який містить Назву інструмента та звук, з яким грає цей інструмент.
    /// </summary>
    internal interface IMusicInstrument
    {
        public string Name { get; set; }

        string Sound();

    }
}
