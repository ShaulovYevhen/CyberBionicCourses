using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleClassApp;

namespace RectangleClassAppTests
{
    [TestClass]
    public class RectangleTests
    {
        private Rectangle _target;
        [TestInitialize]
        public void Init()
        {
            _target = new Rectangle(10, 10);
        }

        [TestMethod]
        public void AreaCalculatorTest()
        {
            Assert.AreEqual(100, _target.AreaCalculator());
        }

        [TestMethod]
        public void PerimeterCalculatorTest()
        {
            Assert.AreEqual(40, _target.PerimeterCalculator());
        }
    }
}