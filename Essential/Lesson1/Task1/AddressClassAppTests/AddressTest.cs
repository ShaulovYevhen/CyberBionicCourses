using System;
using AddressClassApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressClassAppTests
{
    [TestClass]
    public class AddressTest
    {
        private Address _target;

        [TestInitialize]
        public void AddR()
        {
            _target = new Address();
        }
        [TestMethod]
        public void CountryTest()
        {
            var actual = _target.Country;
            Assert.AreEqual(null,actual);
        }
        [TestMethod]
        public void CityTest()
        {
            var actual = _target.City;
            Assert.AreEqual(null, actual);
        }
        [TestMethod]
        public void StreetTest()
        {
            var actual = _target.Street;
            Assert.AreEqual(null, actual);
        }
        [TestMethod]
        public void HouseTest()
        {
            var actual = _target.House;
            Assert.AreEqual(null, actual);
        }
        [TestMethod]
        public void ApartmentTest()
        {
            var actual = _target.Apartment;
            Assert.AreEqual(null, actual);
        }

    }
}
