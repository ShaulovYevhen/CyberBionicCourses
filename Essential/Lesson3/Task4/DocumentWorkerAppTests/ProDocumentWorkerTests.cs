using DocumentWorkerApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocumentWorkerAppTests
{
    [TestClass]
    public class ProDocumentWorkerTests
    {
        private ProDocumentWorker _target;

        [TestInitialize]
        public void Init()
        {
            _target = new ProDocumentWorker();
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
            Assert.AreEqual("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт", _target.SaveDocument());
        }
    }
}