using BookApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookAppTests.Model
{
    [TestClass]
    public class TitleTests
    {
        private Title _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Title("title");
        }

        [TestMethod]
        public void Show()
        {
            _target.Show();
        }
    }
}