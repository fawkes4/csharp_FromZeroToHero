using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal interface ICountry
    {
        public int Population { get; set; }
        public string Gymn { get; set; }
        public string Flag { get; set; }
        public string History { get; set; }
    }
}
