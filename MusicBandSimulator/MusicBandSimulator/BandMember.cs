using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    /// <summary>
    /// Об'єкт - Учасник Гурту. Містить конструктор для створення нового учасника з ім'ям та 
    /// музичним інструментом. Таком містить метод, який дозволяє учаснику гурту 
    /// грати на своєму інструменті.
    /// </summary>
    internal class BandMember
    {
        public string NameOfMember { get; set; }
        public IMusicInstrument MemberInstrument { get; set; }

        public BandMember(string nameOfMember, IMusicInstrument memberInstrument)
        {
            this.NameOfMember = nameOfMember;
            this.MemberInstrument = memberInstrument;
        }

        public void Perform()
        {
            Console.WriteLine($"{NameOfMember} is playing on the {MemberInstrument.Name} and we hear : {MemberInstrument.Sound()}");
        }
    }
}
