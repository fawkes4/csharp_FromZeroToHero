using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Lithuania: History, ICountry
    {
        public int Population { get; set; }
        public string Gymn { get; set; }
        public string Flag { get; set; }

        public Lithuania(int population, string gymn, string flag, string deadRussians) : base(deadRussians)
        {
            this.Population = population;
            this.Gymn = gymn;
            this.Flag = flag;
        }

        private string Weapon()
        {
            return "we give you all u want to kill russians";
        }

        public override void PolishLithuanianCommonwealth()
        {
            Console.WriteLine("It's a konfederation of two monarchies.");
        }

        public override void Symbols()
        {
            Console.WriteLine($"*singing {Gymn} under the {Flag} flag*") ;
        }
    }
}
