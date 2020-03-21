using DocumentWorkerApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocumentWorkerAppTests
{
    [TestClass]
    public class DocumentWorkerTests
    {
        private DocumentWorker _target;
        [TestInitialize]
        public void Init()
        {
            _target = new DocumentWorker();
        }
        
        [TestMethod]
        public void OpenDocumentTest()
        {
            Assert.AreEqual("Документ открыт",_target.OpenDocument());
        }

        [TestMethod]
        public void EditDocumentTest()
        {
            Assert.AreEqual("Редактирование документа доступно в версии Про", _target.EditDocument());
        }

        [TestMethod]
        public void SaveDocumentTest()
        {
            Assert.AreEqual("Сохранение документа доступно в версии Про", _target.SaveDocument());
        }
    }
}
