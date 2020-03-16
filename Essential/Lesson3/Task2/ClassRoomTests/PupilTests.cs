using ClassRoomApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoomTests
{
    [TestClass]
    public class PupilTests
    {
        private Pupil _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Pupil();
        }

        [TestMethod]
        public void StudyTest()
        {
            Assert.AreEqual("Study", _target.Study());
        }

        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Read", _target.Read());
        }

        [TestMethod]
        public void WriteTest()
        {
            Assert.AreEqual("Write", _target.Write());
        }

        [TestMethod]
        public void RelaxTest()
        {
            Assert.AreEqual("Relax", _target.Relax());
        }
    }
}