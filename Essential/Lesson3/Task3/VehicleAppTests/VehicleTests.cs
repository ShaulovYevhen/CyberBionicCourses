using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;

namespace VehicleAppTests
{
    [TestClass]
    public class VehicleTests
    {
        private Vehicle _target;

        [TestInitialize]
        public void Init()
        {
            var price = 1000;
            var speed = 10000;
            var releaseYear = 1999;
            _target = new Vehicle(price, speed, releaseYear);

        }
        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Price: 1000, Speed: 10000, ReleaseYear: 1999", _target.ToString());
        }
    }
}