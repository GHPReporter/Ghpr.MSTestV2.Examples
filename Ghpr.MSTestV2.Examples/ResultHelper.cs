using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ghpr.MSTest.Examples
{
    public static class ResultHelper
    {
        public static void RandomResultMethod()
        {
            var r = new Random();
            var randValue = r.Next(1000);
            if (randValue > 0 && randValue <= 249)//passed
            {
                Assert.AreEqual(1, 1);
            }
            else if (randValue > 249 && randValue <= 499)//failed
            {
                Assert.AreEqual(1, 2);
            }
            else if (randValue > 499 && randValue <= 749)//broken
            {
                throw new Exception("Broken:(");
            }
            else if (randValue > 749)//inconclusive
            {
                Assert.Inconclusive("Iconc. test");
            }
        }
    }
}