using System;

namespace PrinterApp
{
    public class Printer
    {
        protected ConsoleColor Color;

        public Printer(ConsoleColor color)
        {
            Color = color;
        }

        public virtual void Print(string value)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
