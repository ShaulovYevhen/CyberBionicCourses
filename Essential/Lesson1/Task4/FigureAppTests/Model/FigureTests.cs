using FigureApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureAppTests.Model
{
    [TestClass]
    public class FigureTests
    {
        private Figure _target1;
        private Figure _target2;
        private Figure _target3;
        private Point[] _point;

        [TestInitialize]
        public void Init()
        {   _point = new Point[5];
            _point[0] = new Point(0,0, "first");
            _point[1] = new Point(0, 5, "second");
            _point[2] = new Point(5, 0, "third");
            _point[3] = new Point(5, 5, "fourth");
            _point[4] = new Point(0, 10, "fifth");
            _target1 = new Figure(_point[0], _point[1], _point[2]);
            _target2 = new Figure(_point[0], _point[1], _point[2], _point[3]);
            _target3 = new Figure(_point[0], _point[1], _point[2], _point[3], _point[4]);
        }
        [TestMethod]
        public void FigureTest()
        {
            // Arrange

            //Act
            var actual1 = _target1.Type;
            var actual2 = _target2.Type;
            var actual3 = _target3.Type;

            //Assert
            Assert.AreEqual("triangle", actual1);
            Assert.AreEqual("square", actual2);
            Assert.AreEqual("pentagon", actual3);
        }

        [TestMethod]
        public void LenghtSideTest()
        {
            //Arrange
            var A = _point[0];
            var B = _point[1];

            //Act
            var actual = _target1.LengthSide(A, B);
            var expected = 5;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void PerimeterCalculatorTests()
        {
            //Arrange

            //Act
            var actual1 = _target1.PerimeterCalculator();
            var actual2 = _target2.PerimeterCalculator();
            var actual3 = _target3.PerimeterCalculator();
            var expected1 = 17.07;
            var expected2 = 24.14;
            var expected3 = 34.14;

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}