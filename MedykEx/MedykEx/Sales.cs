using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedykEx
{
    public class Sales
    {
        public string InvoiceId { get; set; }
        public string SalesPerson { get; set; }
        public double Amount { get; set; }
        public double CommissionPaid { get; set; }
    }
}
