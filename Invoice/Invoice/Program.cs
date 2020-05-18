using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice obj = new Invoice("678904", "Alex", "Foxtrot")
            {
                article = "USB-hab",
                cost = 1400,
                quantity = 6
            };
            obj.CostCalculation(true);
        }
    }
}
