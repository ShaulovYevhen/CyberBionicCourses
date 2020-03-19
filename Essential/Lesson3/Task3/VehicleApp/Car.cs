namespace VehicleApp
{
    public class Car : Vehicle
    {
        public Car(int price, int speed, int releaseYear) : base(price, speed, releaseYear)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}