using BookApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookAppTests.Model
{
    [TestClass]
    public class ContentTests
    {
        private Content _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Content("content");
        }

        [TestMethod]
        public void Show()
        {
            _target.Show();
        }
    }
}
