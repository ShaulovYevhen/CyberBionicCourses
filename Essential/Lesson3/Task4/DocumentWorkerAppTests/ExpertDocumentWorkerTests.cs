using DocumentWorkerApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocumentWorkerAppTests
{
    [TestClass]
    public class ExpertDocumentWorkerTests
    {
        private ExpertDocumentWorker _target;

        [TestInitialize]
        public void Init()
        {
            _target = new ExpertDocumentWorker();
        }

        [TestMethod]
        public void OpenDocumentTest()
        {
            Assert.AreEqual("Документ открыт", _target.OpenDocument());
        }

        [TestMethod]
        public void EditDocumentTest()
        {
            Assert.AreEqual("Документ отредактирован", _target.EditDocument());
        }

        [TestMethod]
        public void SaveDocumentTest()
        {
            Assert.AreEqual("Документ сохранен в новом формате", _target.SaveDocument());
        }
    }
}