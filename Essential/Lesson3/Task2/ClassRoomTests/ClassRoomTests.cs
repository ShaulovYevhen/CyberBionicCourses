using ClassRoomApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoomTests
{
    [TestClass]
    public class ClassRoomTests
    {
        private ClassRoom _target;

        [TestInitialize]
        public void Init()
        {
            Pupil[] pupils = new Pupil[4];
            pupils[0] = new GoodPupil();
            pupils[1] = new GoodPupil();
            pupils[2] = new BadPupil();
            pupils[3] = new ExcellentPupil();
            _target = new ClassRoom(pupils[0], pupils[1], pupils[2], pupils[3]);
        }

        [TestMethod]
        public void ClassRoomStudyTest()
        {
            Assert.AreEqual("Study = Good pupil Study\nStudy = Good pupil Study\nStudy = Bad pupil Study\nStudy = Excellent pupil Study\n", _target.ClassRoomStudy());
        }
        [TestMethod]
        public void ClassRoomReadTest()
        {
            Assert.AreEqual("Read = Good pupil Read\nRead = Good pupil Read\nRead = Bad pupil Read\nRead = Excellent pupil Read\n", _target.ClassRoomRead());
        }
        [TestMethod]
        public void ClassRoomWrireTest()
        {
            Assert.AreEqual("Write = Good pupil Write\nWrite = Good pupil Write\nWrite = Bad pupil Write\nWrite = Excellent pupil Write\n", _target.ClassRoomWrite());
        }
        [TestMethod]
        public void ClassRoomRelaxTest()
        {
            Assert.AreEqual("Relax = Good pupil Relax\nRelax = Good pupil Relax\nRelax = Bad pupil Relax\nRelax = Excellent pupil Relax\n", _target.ClassRoomRelax());
        }
    }
}
