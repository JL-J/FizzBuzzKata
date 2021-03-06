﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzerTests
    {
        [TestMethod]
         [DataRow(1,"1")]
         [DataRow(2, "2")]
         [DataRow(14, "14")]
         [DataRow(37, "37")]
         [DataRow(88, "88")]
        public void FizzBuzz_WhenNotDivisable_ReturnsInput(int input, string expected)
        {
            string actual = FizzBuzzer.GetValue(input);
            Assert.AreEqual(expected, actual);      
        }

        [TestMethod]
         [DataRow(3)]
         [DataRow(6)]
         [DataRow(12)]
         [DataRow(27)]
        public void FizzBuzz_WhenDivisableBy3_ReturnsFizz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
         [DataRow(5)]
         [DataRow(10)]
         [DataRow(50)]
         [DataRow(100)]
        public void FizzBuzz_WhenDivisableBy5_ReturnsBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]
         [DataRow(15)]
         [DataRow(30)]
         [DataRow(60)]
         [DataRow(75)]
        public void FizzBuzz_WhenDisableBy15_ReturnsFizzBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output); 
        }

    }
}
