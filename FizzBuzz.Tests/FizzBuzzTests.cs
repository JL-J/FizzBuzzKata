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

        [TestMethod]
        public void FizzBuzz_When2_Returns2()
        {
            int input = 2;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("2", output);
        }

        [TestMethod]
        public void FizzBuzz_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
    }
}
