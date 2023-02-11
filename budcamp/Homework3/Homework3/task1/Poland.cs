using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Poland: ICountry
    {
        public int Population { get; set; }
        public string Gymn { get; set; }
        public string Flag { get; set; }
        public string History { get; set; }
        public string Shliahta { get; set; }

        public Poland (string shliahta) : this(30_000_000, "sche Polska nie zginiela", "white and red", shliahta, "tez chce")
        {
            Console.WriteLine("Cy est to czas uje sie vyjobuvaty?");
        }

        public Poland(int population, string gymn, string flag, string shliahta, string deadRussians)
        {
            if(population > 40000000)
            {
                shliahta = shliahta.ToUpper();
            }
            else
            {
                shliahta = shliahta.ToLower();
            }

            this.Population = population;
            this.Gymn = gymn;
            this.Flag = flag;
            this.Shliahta = shliahta;
        }

        public void PolishLithuanianCommonwealth()
        {
            Console.WriteLine("It's my empire.");
        }

        public void GetSymbols()
        {
            Console.WriteLine($"*singing {Gymn} under the {Flag} flag*");
        }

        public string GetPolskaKurwa(int money)
        {
            int enoughMoney = 30;

            if (money > enoughMoney)
            {
                return "fine blowjob";
            }

            return "bidnota! ya pierdolie";
        }
    }
}
