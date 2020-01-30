using BookApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookAppTests.Model
{
    [TestClass]
    public class BookTests
    {
        private Book _target;

        [TestInitialize]
        public void Init()
        {
            var title = new Title("title");
            string author = "author";
            string content = "content";
            _target = new Book(title, author, content);
        }

        [TestMethod]
        public void ShowTest()
        {
            var actual = _target.ToString();
            Assert.AreEqual("_title: title, _author: author, _content: content", actual);
        }
    }
}