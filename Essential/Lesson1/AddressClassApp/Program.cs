using System;

namespace AddressClassApp
{
    class Address
    {
        private string _index;
        public string Index
        {
            get { return _index; }
            set { _index = value; }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _street;
        public string Street
        {
            get { return _street;}
            set { _street = value; }
        }

        private string _house;
        public string House
        {
            get { return _house; }
            set { _house = value; }
        }

        private string _apartment;
        public string Apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
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

            Console.WriteLine($"Address: {address.Index}\nCountry: {address.Country}\nCity: {address.City}\nHouse: {address.House}\nApartment: {address.Apartment} {address.House}");
            Console.ReadKey();
        }
    }
}
