using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrinterApp;

namespace PrinterAppTests
{
    [TestClass]
    public class PrinterTests
    {
        private Printer _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Printer(ConsoleColor.Red);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
