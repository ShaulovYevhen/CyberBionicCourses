using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserApp;

namespace UserAppTests
{
    [TestClass]
    public class UserTests
    {
        private User _target;

        [TestInitialize]
        public void Init()
        {
            var login = "login";
            var firstName = "firstName";
            var secondName = "secondName";
            var age = 19;
            DateTime date = new DateTime();
            _target = new User(login, firstName, secondName, age);
            //(логин, имя, фамилия, возраст, дата заполнения анкеты). 
        }

        [TestMethod]
        public void ShowTest()
        {
            var actual = _target.ToString();
            Assert.AreEqual("Login: login, FirstName: firstName, SecondName: secondName, Age: 19", actual);
        }
    }
}
