using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        public void KFBTest_InputNonDivisibleNumber_ExpectNumber()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();

            Assert.AreEqual("1", kfb.FizzBuzz(1));
            Assert.AreEqual("2", kfb.FizzBuzz(2));
            Assert.AreEqual("4", kfb.FizzBuzz(4));
        }

        [TestMethod]
        public void KFBTest_DivisibleByOrContains3_ExpectFizz()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();

            Assert.AreEqual("Fizz", kfb.FizzBuzz(3));
            Assert.AreEqual("Fizz", kfb.FizzBuzz(6));
            Assert.AreEqual("Fizz", kfb.FizzBuzz(9));
            Assert.AreEqual("Fizz", kfb.FizzBuzz(13));
            Assert.AreEqual("Fizz", kfb.FizzBuzz(23));
            Assert.AreEqual("Fizz", kfb.FizzBuzz(37));
        }

        [TestMethod]
        public void KFBTest_DivisibleByOrContains5_ExpectBuzz()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();

            Assert.AreEqual("Buzz", kfb.FizzBuzz(5));
            Assert.AreEqual("Buzz", kfb.FizzBuzz(10));
            Assert.AreEqual("Buzz", kfb.FizzBuzz(25));
            Assert.AreEqual("Buzz", kfb.FizzBuzz(56));
            Assert.AreEqual("Buzz", kfb.FizzBuzz(52));
            Assert.AreEqual("Buzz", kfb.FizzBuzz(59));
        }
        
        [TestMethod]
        public void KFBTest_ContainsOrIsDivisibleByBoth_ExpectFizzBuzz()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();

            Assert.AreEqual("FizzBuzz", kfb.FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", kfb.FizzBuzz(30));
            Assert.AreEqual("FizzBuzz", kfb.FizzBuzz(45));
            Assert.AreEqual("FizzBuzz", kfb.FizzBuzz(54));
            Assert.AreEqual("FizzBuzz", kfb.FizzBuzz(35));
        }

        [TestMethod]
        public void KFBTest_InputOutOfRange_ExpectEmptyString()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();

            Assert.AreEqual("", kfb.FizzBuzz(0));
            Assert.AreEqual("", kfb.FizzBuzz(101));
            Assert.AreEqual("", kfb.FizzBuzz(256));
        }
    }
}
