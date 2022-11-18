using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedykEx
{
    public class SalesRep
    {
        public string SalesPerson { get; }
        public List<Sales> SalesList { get; }

        public SalesRep(string salePerson, List<Sales> salesList)
        {
            SalesPerson = salePerson;
            SalesList = salesList;
        }


        /* Write a method to pay the sales commission for the Sales made by this salesperson
         * 
         * Assumptions:
         * Only the unpaid sales(CommissionPaid=0) records will be used for payment
         * 
         * 
         * Calculation for the CommissionPaid:
         * Sales commission is calculated as described below
         * 5% of the invoice amount <= $2000 + 
         * 4% of the invoice amount >$2000 and <=$10000 +
         * 3% of the invoice amount >$10000
         * For examples, 
         * 1. If Amount is 1000 then CommissionPaid will be $50
         * 2. If Amount is 6000 then CommissionPaid will be 260
         * 3. If Amount is 12000 then CommissionPaid will be $480
         * 
         * Pay
         * _salesList.CommissionPaid should be updated with the correct amount as described above
         * Method should return the total commission just paid.
         */


        // Implement here
        public double PayCommission(List<Sales> SalesList, string nameSalesPerson)
        {
            double commission = 0;
            double commAmount = 0;

            //var payment = from employee in SalesList where employee.SalesPerson == nameSalesPerson select employee;
            var payment = SalesList.Where(s => s.SalesPerson == nameSalesPerson);

            foreach (var t in payment.Where(s => s.CommissionPaid == 0))
            {
                if (t.Amount <= 2000)
                {
                    commission = t.Amount * 0.05;
                    t.CommissionPaid = commission;
                }
                else if (t.Amount > 2000 && t.Amount <= 10000)
                {
                    commission = t.Amount * 0.04;
                    t.CommissionPaid = commission;
                }
                else if (t.Amount > 10000)
                {
                    commission = t.Amount * 0.03;
                    t.CommissionPaid = commission;
                }
                commAmount += commission;
            }

            return commAmount;
        }

    }
}
