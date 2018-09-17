using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ghpr.MSTest.Examples.Cat1
{
    [TestClass]
    public class ParamTestClass
    {
        [TestMethod]
        public void SomeTestName()
        {
            System.Console.WriteLine($"Test");
            Thread.Sleep(100);
        }
    }
}