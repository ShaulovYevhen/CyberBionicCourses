using ClassRoomApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoomTests
{
    [TestClass]
    public class ExcellentPupilTests
    {
        private ExcellentPupil _target;

        [TestInitialize]
        public void Init()
        {
            _target = new ExcellentPupil();
        }

        [TestMethod]
        public void StudyTest()
        {
            Assert.AreEqual("Excellent pupil Study", _target.Study());
        }

        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Excellent pupil Read", _target.Read());
        }

        [TestMethod]
        public void WriteTest()
        {
            Assert.AreEqual("Excellent pupil Write", _target.Write());
        }

        [TestMethod]
        public void RelaxTest()
        {
            Assert.AreEqual("Excellent pupil Relax", _target.Relax());
        }
    }
}