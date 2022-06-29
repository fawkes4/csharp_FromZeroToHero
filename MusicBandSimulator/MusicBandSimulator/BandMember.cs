using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    /// <summary>
    /// Об'єкт - Учасник Гурту. Містить конструктор для створення нового учасника з ім'ям та музичним інструментом. Таком містить метод, який дозволяє учаснику гурту грати на своєму інструменті.
    /// </summary>
    internal class BandMember
    {
        public string nameOfMember { get; set; }
        public IMusicInstrument memberInstrument { get; set; }

        public BandMember(string nameOfMember, IMusicInstrument memberInstrument)
        {
            this.nameOfMember = nameOfMember;
            this.memberInstrument = memberInstrument;
        }

        public void BandMemberPerform()
        {
            Console.WriteLine($"{nameOfMember} is playing on the {memberInstrument}");
        }
    }
}
