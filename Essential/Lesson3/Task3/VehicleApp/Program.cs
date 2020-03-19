using System;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ship = new Ship(20000, 120, 2000)
            {
                Passengers = 28, Port = "Севастополь"
            };
            Console.WriteLine(ship.ToString());
            Console.ReadKey();
        }
    }
}
