using System;

namespace AddressClassApp
{
    class Address
    {
        private string index;
        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string street;
        public string Street
        {
            get { return street;}
            set { street = value; }
        }

        private string house;
        public string House
        {
            get { return house; }
            set { house = value; }
        }

        private string apartment;
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "55500/02";
            address.Country = "USA";
            address.City = "Albukerke";
            address.Street = "Pushkinsa";
            address.House = "13b";
            address.Apartment = "23a";

            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
            Console.WriteLine(address.Index);
            Console.ReadKey();
        }
    }
}
