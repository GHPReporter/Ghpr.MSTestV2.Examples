using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ghpr.MSTest.Examples
{
    [TestClass]
    public class Class1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestProperty("SomeProperty", "SomeName")]
        public void Test1()
        {
            System.Console.WriteLine("Some test logging");
            TestContext.Properties.Add("SuperKey1", "SuperValue1");
            //Assert.AreEqual(1, 3);
        }

        [TestMethod]
        [TestProperty("SomeProperty", "SomeName")]
        public void Test2()
        {
            System.Console.WriteLine("Some test logging");
            TestContext.Properties.Add("SuperKey2", "SuperValue2");
            TestContext.WriteLine("Testline");
            //Assert.AreEqual(1, 3);
        }
    }
}
