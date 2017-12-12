using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VersionamentoGit;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteMetodoSoma()
        {
            Assert.AreEqual(Class1.soma(1, 2), 3);

        }
        [TestMethod]
        public void TesteMetodoSubtracao()
        {
            Assert.AreEqual(Class1.subtracao(2, 1), 1);

        }
        [TestMethod]
        [Ignore]
        public void testeNaoPronto()
        {
        }
    }
}
