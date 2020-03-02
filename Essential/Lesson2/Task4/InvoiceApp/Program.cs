using System;

namespace InvoiceApp
{
    class Program
    {
        static void Main()
        {
            Invoice inv = new Invoice(63, "Alex", "Foxtrot") { Article = "laptop", Quantity = 22 };
            Console.WriteLine(inv.Cost(true));
            Console.WriteLine(inv.Cost(false));
            Console.ReadKey();
        }
    }
}
