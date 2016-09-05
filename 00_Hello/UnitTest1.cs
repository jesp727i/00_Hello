using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Hello
{
    [TestClass]
    public class UnitTest1
    {
        string i = "hello";
        [TestMethod]
        public void TestHello()
        {
            Assert.AreEqual(i, Functions.Hello());
        }
        [TestMethod]
        public void TestHelloFred()
        {
            Assert.AreEqual(i, ", Fred", Functions.Hello(", Fred"));
        }
    }
}
