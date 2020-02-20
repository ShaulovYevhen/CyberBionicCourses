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
            //Arrange
            var actual1 = _target.X;
            var actual2 = _target.Y;
            var actual = _target.Name;

            //Act

            //Assert
            Assert.AreEqual(0,actual1);
            Assert.AreEqual(5, actual2);
            Assert.AreEqual("Point", actual);
        }
    }
}