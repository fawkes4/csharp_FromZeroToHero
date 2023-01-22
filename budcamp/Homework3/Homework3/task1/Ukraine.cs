using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Ukraine : ICountry
    {
        public int Population { get; set; }
        public string Gymn { get; set; }
        public string Flag { get; set; }

        const bool independence = true;

        public readonly string vlomytyPizdy;

        public History History { get; set; }

        History history = new History("not enouph");

        public override void PolishLithuanianCommonwealth()
        {
            base.PolishLithuanianCommonwealth();
            Console.WriteLine("Why am I here? Bohdan, plz tell me ASAP.");
        }

        public Ukraine (int population, string gymn, string flag, string deadRussians) : base(deadRussians)
        {
            Population = population;
            Flag = flag;
            Gymn = gymn;
        }

        public override void Symbols()
        {
            Console.WriteLine($"*singing {Gymn} under the {Flag} flag*");
        }

        protected void Borshch()
        {
            Console.WriteLine("if Ua approve you can eat me");
        }

        public static int TakingHelp()
        {
            Console.WriteLine("we ty for support");
            int deadRussians = 120000;

            return deadRussians;
        }
    }
}
