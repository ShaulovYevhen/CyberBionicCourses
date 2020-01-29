using System;
namespace AddressClassApp
{
    public class Address
    {
        public string Index { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Apartment { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Address address = new Address
            {
                Index = "55500",
                Country = "USA",
                City = "Albuquerque",
                Street = "Pushkin",
                House = "13b",
                Apartment = "23a"
            };

            Console.WriteLine($"Address: {address.Index}\nCountry: {address.Country}\nCity: {address.City}\nHouse: {address.House}\nApartment: {address.Apartment}");
            Console.ReadKey();
        }
    }
}