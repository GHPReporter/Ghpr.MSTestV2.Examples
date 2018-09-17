using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ghpr.MSTest.Examples.Cat2
{
    [TestClass, Ignore]
    public class TestClass08
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
    }
}