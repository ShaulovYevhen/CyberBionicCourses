using System;

namespace ConverterApp
{
    class Program
    {
        static void Main()
        {
            var converter = new Converter(8.56, 10.14, 0.12);
            Console.WriteLine(converter.UaToEu(200));
            Console.WriteLine(converter.EuToUa(200));
            Console.ReadKey();
        }
    }
}