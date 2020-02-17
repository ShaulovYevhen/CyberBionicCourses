using FigureApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureAppTests.Model
{
    [TestClass]
    public class FigureTests
    {
        private Figure _target;
        private Point[] point;

        [TestInitialize]
        public void Init()
        {
            _target = new Figure(point[0], point[1], point[2]);
            _target = new Figure(point[0], point[1], point[2], point[3]);
            _target = new Figure(point[0], point[1], point[2], point[3], point[4]);
            
        }

        [TestMethod]
        public void LenghtSide()
        {

        }
        [TestMethod]
        public void FigureTest()
        {
        }
    }
}