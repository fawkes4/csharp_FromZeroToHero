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

        public History(string deadRussians)
        {
            DeadRussians = deadRussians;
        }

        public virtual void ToBePolishLithuanianCommonwealth() 
        {
            Console.WriteLine("time the moskow has to be burned");
        }

        public abstract void GetSymbols();
    }
}
