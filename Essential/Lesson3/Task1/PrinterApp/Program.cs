using System;

namespace PrinterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Color print = new Color(ConsoleColor.DarkMagenta);
            print.Print("asdasd");

            Printer printUp = print;
            printUp.Print("sadasda");

            Color print1 = new Color(ConsoleColor.Blue);
            print1.Print("sadsadasd");
            Console.ReadKey();
        }
    }
}
