using System;
using FigureApp.Model;

namespace FigureApp
{
    class Program
    {
        static void Main()
        {
            var figure = new Figure(new Point( 1, 1,"A"), new Point( 1, 4,"B"), new Point( 4, 4, "C"));
            Console.Write("{0}, P = ", figure.Type);
            Console.Write(figure.PerimeterCalculator());
            Console.ReadKey();
        }
    }
}
