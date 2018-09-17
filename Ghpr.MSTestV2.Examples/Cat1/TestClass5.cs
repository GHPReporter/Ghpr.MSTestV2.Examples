using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ghpr.MSTest.Examples.Cat1
{
    [TestClass]
    public class TestClass5
    {
        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(200);
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Thread.Sleep(100);
            Assert.AreEqual(1, 1);
        }
    }
}