using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;

namespace VehicleAppTests
{
    [TestClass]
    public class CarTests
    {
        private Car _target;

        [TestInitialize]
        public void Init()
        {
            int price=123;
            int speed=123;
            int releaseYear=2312;
            _target = new Car(price,speed,releaseYear);
        }

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Price: 123, Speed: 123, ReleaseYear: 2312", _target.ToString());
        }
    }
}
