using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedykEx
{
    internal class SalesRep
    {
        public string SalesPerson { get; }
        public List<Sales> SalesList { get; }

        public SalesRep(string salePerson, List<Sales> salesList)
        {
            SalesPerson = salePerson;
            SalesList = salesList;
        }
    }
}
