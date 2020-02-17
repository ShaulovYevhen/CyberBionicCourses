using FigureApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureAppTests.Model
{
    [TestClass]
    public class PointTests
    {
        private Point _target;

        [TestInitialize]
        public void Init()
        {
            var x = 0;
            var y = 5;
            var name = "Point";
            _target = new Point(x, y, name);
        }

        [TestMethod]
        public void PointTest()
        {
            var actual1 = _target.X;
            Assert.AreEqual(0,actual1);
            var actual2 = _target.Y;
            Assert.AreEqual(5, actual2);
            var actual = _target.Name;
            Assert.AreEqual("Point", actual);
        }
    }
}