using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice("678904", "Alex", "Foxtrot")
            {
                Article = "USB-hab",
                Quantity = 6
            };

            inv.CostCalculation(true);
        }
    }
}
