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
                List<BandMember> bandMembers2 = new List<BandMember>();

                //цикл що проходиться по колекції з усіма наявними об'єктами, перевіряючи, чи існують
                //уже музиканти, що грають на інструменті нового музиканта, якого я хочу добавити в гурт.
                //Добавляю всіх музикантів з унікальним інструментом до новоствореного Ліста. Якщо музикант
                //з інструментом такий, який вже є в колективі - добавляю його в новий ліст. По завершенні
                //циклу - надаю старому (основному Лісту значення нового ліста).
                foreach (BandMember member in bandMembers)
                {
                    var instrumentType = member.MemberInstrument.GetType();
                    var newInstrumentType = newBandMember.MemberInstrument.GetType();

                    if (instrumentType != newInstrumentType) //ToDo GetType
                    {
                        bandMembers2.Add(member);
                    }
                }

                bandMembers2.Add(newBandMember);
                bandMembers = bandMembers2;
            }
        }


    }
}
