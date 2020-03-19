namespace VehicleApp
{
    public class Vehicle
    {
        public Vehicle(int price, int speed, int releaseYear)
        {
            Price = price;
            Speed = speed;
            ReleaseYear = releaseYear;
        }

        public int Price { get; set; }

        public int Speed { get; set; }

        public int ReleaseYear { get; set; }

        public override string ToString()
        {
            return $"{nameof(Price)}: {Price}, {nameof(Speed)}: {Speed}, {nameof(ReleaseYear)}: {ReleaseYear}";
        }
    }
}