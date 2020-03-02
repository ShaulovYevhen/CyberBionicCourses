using InvoiceApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvoiceAppTests
{
    [TestClass]
    public class InvoiceTests
    {
        private Invoice _target;

        [TestInitialize]
        public void Init()
        {
            var account = 1;
            var customer = "customer";
            var provider = "provider";
            _target = new Invoice(account, customer, provider)
                { Article = "Article", Quantity = 10 };
        }

        [TestMethod]
        public void CostTest()
        {
            Assert.AreEqual("Cуммa оплаты: 1166,67", _target.Cost(true));
        }
    }
}