using System;
using System.Linq;
using System.Collections.Generic;
using MedykEx;

public class Program
{
    /* The following console application tries to solve the following
     * 1. List the sales made by a salesperson
     * 2. Pay the sales commission for a salesperson
     */
    public static void Main()
    {
        Sales allSales = new Sales();

        var sales = new List<Sales>() 
        {
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

        //var displayBillSales = from bill in sales where bill.SalesPerson == "Bill" select bill.InvoiceId;
        var displayBillSales = sales.Where(s => s.SalesPerson.Contains("Bill")).Select(s => s.InvoiceId);

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
    }
}