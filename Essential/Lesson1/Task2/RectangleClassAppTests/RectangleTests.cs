using RectangleClassApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectangleClassApp.Tests
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
            var expected = 100;
            var actual = _target.AreaCalculator();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PerimeterCalculatorTest()
        {
            var expected = 40;
            var actual = _target.PerimeterCalculator();
            Assert.AreEqual(expected, actual);
        }
    }
}