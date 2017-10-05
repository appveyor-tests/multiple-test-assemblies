using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace multiple_test_assemblies
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(1 == 1);
        }
    }
}
