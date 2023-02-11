using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Lithuania: ICountry
    {
        public int Population { get; set; }
        public string Gymn { get; set; }
        public string Flag { get; set; }
        public string History { get; set; }

        public Lithuania(int population, string gymn, string flag, string deadRussians)
        {
            this.Population = population;
            this.Gymn = gymn;
            this.Flag = flag;
        }

        private string AskForWeapon()
        {
            return "we give you all u want to kill russians";
        }

        public void PolishLithuanianCommonwealth()
        {
            Console.WriteLine("It's a konfederation of two monarchies.");
        }

        public void Symbols()
        {
            Console.WriteLine($"*singing {Gymn} under the {Flag} flag*") ;
        }
    }
}
