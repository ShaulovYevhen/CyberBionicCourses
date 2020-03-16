using ClassRoomApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoomTests
{
    [TestClass]
    public class BadPupilTests
    {
        private BadPupil _target;

        [TestInitialize]
        public void Init()
        {
            _target = new BadPupil();
        }

        [TestMethod]
        public void StudyTest()
        {
            Assert.AreEqual("Bad pupil Study", _target.Study());
        }

        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Bad pupil Read", _target.Read());
        }

        [TestMethod]
        public void WriteTest()
        {
            Assert.AreEqual("Bad pupil Write", _target.Write());
        }

        [TestMethod]
        public void RelaxTest()
        {
            Assert.AreEqual("Bad pupil Relax", _target.Relax());
        }
    }
}