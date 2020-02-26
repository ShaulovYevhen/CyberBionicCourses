using System;
using ConverterApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterAppTests
{
    [TestClass]
    public class ConveterTests
    {
        private Converter _target;

        [TestInitialize]
        public void Init()
        {
            var usd = 27.5;
            var eur = 30.4;
            var rub = 0.3;
            _target = new Converter(usd, eur, rub);
        }

        [TestMethod]
        public void UaToUsTest()
        {
            Assert.AreEqual(3.64, _target.UaToUs(100));
        }

        [TestMethod]
        public void UaToEuTest()
        {
            Assert.AreEqual(3.29, _target.UaToEu(100));
        }

        [TestMethod]
        public void UaToRuTest()
        {
            Assert.AreEqual(333.33, _target.UaToRu(100));
        }

        [TestMethod]
        public void UsToUaTest()
        {
            Assert.AreEqual(2750, _target.UsToUa(100));
        }

        [TestMethod]
        public void EuToUaTest()
        {
            Assert.AreEqual(3040, _target.EuToUa(100));
        }
        [TestMethod]
        public void RuToUaTest()
        {
            Assert.AreEqual(30, _target.RuToUa(100));
        }
    }
}