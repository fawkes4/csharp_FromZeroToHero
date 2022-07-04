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

        public List<BandMember> bandMembers;

        public MusicBand(string bandName)
        {
            this.BandName = bandName;
            bandMembers = new List<BandMember>();
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
                //Хочу перевірити, чи вже хтось з учасників гурту грає на типі інструменту,
                //який я намагаюся добавити. Для цього запускаю цикл for, і змінній "і"
                //надаю значень індексів в Лісті членів гурту.
                //Далі оголошую змінні, яким присвоюю значення типу інструменту, на якому
                //грає новий учасник та порівнюю його з типом інструменту, на якому грає
                //очередняра з Ліста існуючих виконавців.
                //В разі співпадіння інструменту - очередняра йде на пенсію, а його місце
                //займає свіжий талант.
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
