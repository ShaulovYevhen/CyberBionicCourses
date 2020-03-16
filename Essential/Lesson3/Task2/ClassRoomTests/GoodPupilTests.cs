using ClassRoomApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoomTests
{
    [TestClass]
    public class GoodPupilTests
    {
        private GoodPupil _target;

        [TestInitialize]
        public void Init()
        {
            _target = new GoodPupil();
        }

        [TestMethod]
        public void StudyTest()
        {
            Assert.AreEqual("Good pupil Study", _target.Study());
        }

        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Good pupil Read", _target.Read());
        }

        [TestMethod]
        public void WriteTest()
        {
            Assert.AreEqual("Good pupil Write", _target.Write());
        }

        [TestMethod]
        public void RelaxTest()
        {
            Assert.AreEqual("Good pupil Relax", _target.Relax());
        }
    }
}
