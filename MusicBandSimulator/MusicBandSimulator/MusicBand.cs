using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandSimulator
{
    /// <summary>
    /// клас Гурту. Містить конструктор Гурту, який приймає його ім'я. 
    /// Має метод, який йому дозволяє грати. Містить метод для добавляння 
    /// нових учасників гурту.
    /// </summary>
    internal class MusicBand
    {
        public string BandName { get; set; }

        List<BandMember> bandMembers = new List<BandMember>();

        public MusicBand(string bandName)
        {
            this.BandName = bandName;
        }

        public void Perform()
        {
            foreach (var bandMember in bandMembers)
            {
                bandMember.Perform();
            }
        }

        public void Add(BandMember newBandMember)
        {
            // умова, яка перевіряє, чи в Лісті є якісь об'єкти.
            if (bandMembers.Count == 0) 
            {
                bandMembers.Add(newBandMember);
            }
            else
            {
                for (int i = 0; i < bandMembers.Count; i++)
                {
                    var newBandMemberType = newBandMember.MemberInstrument.GetType();
                    var bandMembersType = bandMembers[i].MemberInstrument.GetType();

                    if (newBandMemberType == bandMembersType)
                    {
                        bandMembers.Remove(bandMembers[i]);
                    }
                }

                bandMembers.Add(newBandMember);
            }
        }
    }
}
