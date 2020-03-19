using System;

namespace VehicleApp
{
    public class Plane : Vehicle
    {
        public Plane(int price, int speed, int releaseYear) : base(price, speed, releaseYear)
        {
        }
        public int Hight { get; set; }
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
            return $"{base.ToString()}, {nameof(_passengers)}: {_passengers}, {nameof(Hight)}: {Hight}, {nameof(Passengers)}: {Passengers}";
        }
    }

}