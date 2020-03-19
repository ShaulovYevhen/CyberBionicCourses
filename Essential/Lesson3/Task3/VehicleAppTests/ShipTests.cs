using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;

namespace VehicleAppTests
{
    [TestClass]
    public class ShipTests
    {
        private Ship _target;

        [TestInitialize]
        public void Init()
        {
            var price = 132;
            var speed = 3123;
            var releaseYear = 31231;
            _target = new Ship(price, speed, releaseYear)
            {
                Passengers = 1121,
                Port = "ooo"
            };
        }

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Price: 132, Speed: 3123, ReleaseYear: 31231, _passengers: 1121, Port: ooo, Passengers: 1121", _target.ToString());
        }
    }
}