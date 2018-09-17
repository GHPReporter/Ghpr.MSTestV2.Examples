using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ghpr.MSTestV2.Examples.Cat1
{
    [TestClass]
    public class DataDriven
    {
        [DataRow(1, 2, 2)]
        [DataRow(1, 2, 3)]
        [DataRow(1, 2, 4)]
        [DataTestMethod]
        public void NewParamTest(int a, int b, int c)
        {
            Assert.AreEqual(a + b, c);
        }
    }
}