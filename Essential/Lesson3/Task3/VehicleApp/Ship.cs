using System;

namespace VehicleApp
{
    public class Ship: Vehicle
    {
        public Ship(int price, int speed, int releaseYear) : base(price, speed, releaseYear)
        {
        }
        
        public string Port { get; set; }
        private int _passengers;
        public int Passengers
        {
            get => _passengers;
            set
            {
                if (_passengers < 0)
                {
                    Console.WriteLine("Количетво пасажиров не может быть отрицательным");
                }
                else
                {
                    _passengers = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(_passengers)}: {_passengers}, {nameof(Port)}: {Port}, {nameof(Passengers)}: {Passengers}";
        }
    }
}