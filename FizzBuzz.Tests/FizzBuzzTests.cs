using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_When1_Returns1()
        {
            int input = 1;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("1", output);      
        }
    }
}
