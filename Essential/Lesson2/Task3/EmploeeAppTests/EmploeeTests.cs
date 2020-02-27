using EmploeeApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmploeeAppTests
{
    [TestClass]
    public class EmploeeTests
    {
        private Emploee _target;

        [TestInitialize]
        public void Init()
        {
            var firstName = "firstName";
            var secondName = "secondName";
            _target = new Emploee(firstName, secondName)
            {
                Post = "manager",
                Experience = 1
            };
        }

        [TestMethod]
        public void CountSalaryTest()
        {
            Assert.AreEqual(400, _target.CountSalary());
        }

        [TestMethod]
        public void TaxTest()
        {
            Assert.AreEqual(80, _target.Tax());
        }

        [TestMethod]
        public void ShowTest()
        {
            Assert.AreEqual("\nИмя: firstName, \nФамилия: secondName, \nДолжность: manager, \nОпыт: 1, \nЗарплата: 400, \nНалог: 80", _target.ToString());
        }
    }
}