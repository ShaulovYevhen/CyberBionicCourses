using BookApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookAppTests.Model
{
    [TestClass]
    public class AuthorTests
    {
        private Author _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Author("author");
        }

        [TestMethod]
        public void Show()
        {
            _target.Show();
        }
    }
}
