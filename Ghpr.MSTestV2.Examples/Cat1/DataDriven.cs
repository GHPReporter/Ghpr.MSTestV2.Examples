using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ghpr.MSTest.Examples.Cat1
{
    public class DataDriven
    {
        [DataTestMethod]
        [DataRow(1, 2, 4)]
        public void Test1()
        {

        }
    }
}