using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice obj = new Invoice("678904", "Alex", "Foxtrot");
            obj.article = "laptop";
            obj.quantity = 6;
            obj.cost = 1400;
            obj.CostCalculation(true);
        }
    }
}
