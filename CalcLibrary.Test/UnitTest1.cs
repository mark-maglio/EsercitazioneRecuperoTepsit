using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double num = 49;
            double numeroaspettato = 7;
            double numeroricevuto = Calc.RadQ(num);
            Assert.AreEqual(numeroaspettato, numeroricevuto);
        }
    }
}
