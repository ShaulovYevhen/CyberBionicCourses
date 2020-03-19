using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;

namespace VehicleAppTests
{
    [TestClass]
    public class PlaneTests
    {
        private Plane _target;

        [TestInitialize]
        public void Init()
        {
            var price = 1231;
            var speed = 12312;
            var releaseYear = 12312;
            _target = new Plane(price, speed, releaseYear)
            {
                Hight = 12312,
                Passengers = 123
            };
        }

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Price: 1231, Speed: 12312, ReleaseYear: 12312, _passengers: 123, Hight: 12312, Passengers: 123", _target.ToString());
        }
    }
}