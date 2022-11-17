using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    /* The following console application tries to solve the following
     * 1. List the sales made by a salesperson
     * 2. Pay the sales commission for a salesperson
     */


    public static void Main()
    {
        var sales = new List<Sales>() {
                new Sales(){ InvoiceId = "INV102", SalesPerson="Bill", Amount=1200,CommissionPaid=60 },
                new Sales(){ InvoiceId = "INV107", SalesPerson="Dave", Amount=4200,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV106", SalesPerson="Paul", Amount=16000,CommissionPaid=0},
                new Sales(){ InvoiceId = "INV103", SalesPerson="Mark", Amount=18000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV101", SalesPerson="Sayeed", Amount=2000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV109", SalesPerson="Christine", Amount=5200,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV108", SalesPerson="Bill", Amount=6000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV104", SalesPerson="Mary", Amount=9800,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV105", SalesPerson="Bill", Amount=12000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV100", SalesPerson="Melissa", Amount=12000,CommissionPaid=0 }
        };
        /* Display all Bill's Sales Records(Both paid and unpaid).         
         */

        // Implement here
        var displayBillSales = from bill in sales where bill.SalesPerson == "Bill" select bill.InvoiceId;

        foreach (var i in displayBillSales)
        {
            Console.WriteLine(i);
        }

        /* Call a method from SalesRep class to pay the sales commission for Bill(only for the sales records with CommissionPaid=0)
        * Display the total commission that has been paid
        */

        // Implement here
        SalesRep payMoney = new SalesRep("personName", sales);

        Console.WriteLine($"total paid commition is: {payMoney.PayCommission(sales, "Bill")}");

        var displayBillSales1 = from bill in sales where bill.InvoiceId == "INV108" select bill.CommissionPaid;
        foreach (var i in displayBillSales1)
        {
            Console.WriteLine(i);
        }

    }
}
public class Sales
{
    public string InvoiceId { get; set; }
    public string SalesPerson { get; set; }
    public double Amount { get; set; }
    public double CommissionPaid { get; set; }

}


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
    public double PayCommission (List<Sales> SalesList, string nameSalesPerson)
    {
        double commission = 0;
        double commAmount = 0;

        var payment = from employee in SalesList where employee.SalesPerson == nameSalesPerson select employee;

        foreach (var t in payment)
        {
            if (t.CommissionPaid == 0)
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
            }
            commAmount += commission;
            commission = 0;
        }

        return commAmount;
    }

}