using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class History
    {
        public string DeadRussians { get; set; }
        public virtual void PolishLithuanianCommonwealth() 
        {
            Console.WriteLine("time the moskow has to be burned");
        }

        public abstract void Symbols();

        public History(string deadRussians)
        {
            DeadRussians = deadRussians;

            deadRussians = "not enough";
        }
    }
}
