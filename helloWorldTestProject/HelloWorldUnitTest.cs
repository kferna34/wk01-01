using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace helloWorldTestProject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expectedResult = "Hello World";
            //act
            string result = wk01_01.Program.HelloWorldToConsole();

            //asert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
