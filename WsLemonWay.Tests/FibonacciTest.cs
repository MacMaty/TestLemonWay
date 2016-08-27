using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WsLemonWay.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        WS_LemonWay ws = new WS_LemonWay();

        [TestMethod]
        public void FibonnaciNumberTestWith100()
        {
            try
            {
                ws.Fibonacci(100);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception)
            {

            }
        }

        [TestMethod]
        public void FibonnaciNumberTestWith10()
        {
            Assert.AreEqual(ws.Fibonacci(10), 55);
        }

        [TestMethod]
        public void FibonnaciNumberTestWith20()
        {
            Assert.AreEqual(ws.Fibonacci(20), 6765);
        }

        [TestMethod]
        public void FibonnaciNumberTestWith0()
        {
            Assert.AreEqual(ws.Fibonacci(0), -1);
        }

        [TestMethod]
        public void FibonnaciNumberTestWith1()
        {
            Assert.AreEqual(ws.Fibonacci(1), 1);
        }


        [TestMethod]
        public void FibonnaciNumberTestWith2()
        {
            Assert.AreEqual(ws.Fibonacci(2), 1);
        }


        [TestMethod]
        public void FibonacciNumberFibonacciPositiveNumber()
        {
            Assert.AreNotEqual(null, ws);
            Assert.AreEqual(8, ws.Fibonacci(6));
        }

        [TestMethod]
        public void FibonacciNumberFibonacciRangeNumber()
        {
            Assert.AreEqual(-1, ws.Fibonacci(101));
            Assert.AreEqual(-1, ws.Fibonacci(1000));
            Assert.AreEqual(-1, ws.Fibonacci(-100));
            Assert.AreEqual(-1, ws.Fibonacci(-1));
        }
    }
}
