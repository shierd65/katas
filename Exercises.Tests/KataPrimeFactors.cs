using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPrimeFactorsTest
    {
        [TestMethod]
        public void PrimeFactorsTest()
        {
            CollectionAssert.AreEqual(new int[] { 2 }, KataPrimeFactors.Factorize(2));
            CollectionAssert.AreEqual(new int[] { 3 }, KataPrimeFactors.Factorize(3));
            CollectionAssert.AreEqual(new int[] { 2, 2 }, KataPrimeFactors.Factorize(4));
            CollectionAssert.AreEqual(new int[] { 5 }, KataPrimeFactors.Factorize(5));
            CollectionAssert.AreEqual(new int[] { 2, 3 }, KataPrimeFactors.Factorize(6));
            CollectionAssert.AreEqual(new int[] { 7 }, KataPrimeFactors.Factorize(7));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, KataPrimeFactors.Factorize(8));
            CollectionAssert.AreEqual(new int[] { 3, 3 }, KataPrimeFactors.Factorize(9));
            CollectionAssert.AreEqual(new int[] { 2, 5 }, KataPrimeFactors.Factorize(10));

            CollectionAssert.AreEqual(new int[] { 11 }, KataPrimeFactors.Factorize(11));
            CollectionAssert.AreEqual(new int[] { 2, 2, 3 }, KataPrimeFactors.Factorize(12));
            CollectionAssert.AreEqual(new int[] { 13 }, KataPrimeFactors.Factorize(13));
            CollectionAssert.AreEqual(new int[] { 2, 7 }, KataPrimeFactors.Factorize(14));
            CollectionAssert.AreEqual(new int[] { 3, 5 }, KataPrimeFactors.Factorize(15));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2 }, KataPrimeFactors.Factorize(16));
            CollectionAssert.AreEqual(new int[] { 17 }, KataPrimeFactors.Factorize(17));
            CollectionAssert.AreEqual(new int[] { 2, 3, 3 }, KataPrimeFactors.Factorize(18));
            CollectionAssert.AreEqual(new int[] { 19 }, KataPrimeFactors.Factorize(19));

            CollectionAssert.AreEqual(new int[] { 2, 2, 5 }, KataPrimeFactors.Factorize(20));
            CollectionAssert.AreEqual(new int[] { 3, 7 }, KataPrimeFactors.Factorize(21));
            CollectionAssert.AreEqual(new int[] { 2, 11 }, KataPrimeFactors.Factorize(22));
            CollectionAssert.AreEqual(new int[] { 23 }, KataPrimeFactors.Factorize(23));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 3 }, KataPrimeFactors.Factorize(24));
            CollectionAssert.AreEqual(new int[] { 5, 5 }, KataPrimeFactors.Factorize(25));
            CollectionAssert.AreEqual(new int[] { 2, 13 }, KataPrimeFactors.Factorize(26));
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, KataPrimeFactors.Factorize(27));
            CollectionAssert.AreEqual(new int[] { 2, 2, 7 }, KataPrimeFactors.Factorize(28));
            CollectionAssert.AreEqual(new int[] { 29 }, KataPrimeFactors.Factorize(29));

            CollectionAssert.AreEqual(new int[] { 2, 3, 5 }, KataPrimeFactors.Factorize(30));
            CollectionAssert.AreEqual(new int[] { 31 }, KataPrimeFactors.Factorize(31));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2, 2 }, KataPrimeFactors.Factorize(32));
            CollectionAssert.AreEqual(new int[] { 3, 11 }, KataPrimeFactors.Factorize(33));
            CollectionAssert.AreEqual(new int[] { 2, 17 }, KataPrimeFactors.Factorize(34));
            CollectionAssert.AreEqual(new int[] { 5, 7 }, KataPrimeFactors.Factorize(35));
            CollectionAssert.AreEqual(new int[] { 2, 2, 3, 3 }, KataPrimeFactors.Factorize(36));
            CollectionAssert.AreEqual(new int[] { 37 }, KataPrimeFactors.Factorize(37));
            CollectionAssert.AreEqual(new int[] { 2, 19 }, KataPrimeFactors.Factorize(38));
            CollectionAssert.AreEqual(new int[] { 3, 13 }, KataPrimeFactors.Factorize(39));

            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 5 }, KataPrimeFactors.Factorize(40));
            CollectionAssert.AreEqual(new int[] { 41 }, KataPrimeFactors.Factorize(41));
            CollectionAssert.AreEqual(new int[] { 2, 3, 7 }, KataPrimeFactors.Factorize(42));
            CollectionAssert.AreEqual(new int[] { 43 }, KataPrimeFactors.Factorize(43));
            CollectionAssert.AreEqual(new int[] { 2, 2, 11 }, KataPrimeFactors.Factorize(44));
            CollectionAssert.AreEqual(new int[] { 3, 3, 5 }, KataPrimeFactors.Factorize(45));
            CollectionAssert.AreEqual(new int[] { 2, 23 }, KataPrimeFactors.Factorize(46));
            CollectionAssert.AreEqual(new int[] { 47 }, KataPrimeFactors.Factorize(47));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2, 3 }, KataPrimeFactors.Factorize(48));
            CollectionAssert.AreEqual(new int[] { 7, 7 }, KataPrimeFactors.Factorize(49));

            CollectionAssert.AreEqual(new int[] { 2, 5, 5 }, KataPrimeFactors.Factorize(50));
            CollectionAssert.AreEqual(new int[] { 3, 17 }, KataPrimeFactors.Factorize(51));
            CollectionAssert.AreEqual(new int[] { 2, 2, 13 }, KataPrimeFactors.Factorize(52));
            CollectionAssert.AreEqual(new int[] { 53 }, KataPrimeFactors.Factorize(53));
            CollectionAssert.AreEqual(new int[] { 2, 3, 3, 3 }, KataPrimeFactors.Factorize(54));
            CollectionAssert.AreEqual(new int[] { 5, 11 }, KataPrimeFactors.Factorize(55));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 7 }, KataPrimeFactors.Factorize(56));
            CollectionAssert.AreEqual(new int[] { 3, 19 }, KataPrimeFactors.Factorize(57));
            CollectionAssert.AreEqual(new int[] { 2, 29 }, KataPrimeFactors.Factorize(58));
            CollectionAssert.AreEqual(new int[] { 59 }, KataPrimeFactors.Factorize(59));

            CollectionAssert.AreEqual(new int[] { 2, 2, 3, 5 }, KataPrimeFactors.Factorize(60));
            CollectionAssert.AreEqual(new int[] { 61 }, KataPrimeFactors.Factorize(61));
            CollectionAssert.AreEqual(new int[] { 2, 31 }, KataPrimeFactors.Factorize(62));
            CollectionAssert.AreEqual(new int[] { 3, 3, 7 }, KataPrimeFactors.Factorize(63));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2, 2, 2 }, KataPrimeFactors.Factorize(64));
            CollectionAssert.AreEqual(new int[] { 5, 13 }, KataPrimeFactors.Factorize(65));
            CollectionAssert.AreEqual(new int[] { 2, 3, 11 }, KataPrimeFactors.Factorize(66));
            CollectionAssert.AreEqual(new int[] { 67 }, KataPrimeFactors.Factorize(67));
            CollectionAssert.AreEqual(new int[] { 2, 2, 17 }, KataPrimeFactors.Factorize(68));
            CollectionAssert.AreEqual(new int[] { 3, 23 }, KataPrimeFactors.Factorize(69));

            CollectionAssert.AreEqual(new int[] { 2, 5, 7 }, KataPrimeFactors.Factorize(70));
            CollectionAssert.AreEqual(new int[] { 71 }, KataPrimeFactors.Factorize(71));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 3, 3 }, KataPrimeFactors.Factorize(72));
            CollectionAssert.AreEqual(new int[] { 73 }, KataPrimeFactors.Factorize(73));
            CollectionAssert.AreEqual(new int[] { 2, 37 }, KataPrimeFactors.Factorize(74));
            CollectionAssert.AreEqual(new int[] { 3, 5, 5 }, KataPrimeFactors.Factorize(75));
            CollectionAssert.AreEqual(new int[] { 2, 2, 19 }, KataPrimeFactors.Factorize(76));
            CollectionAssert.AreEqual(new int[] { 7, 11 }, KataPrimeFactors.Factorize(77));
            CollectionAssert.AreEqual(new int[] { 2, 3, 13 }, KataPrimeFactors.Factorize(78));
            CollectionAssert.AreEqual(new int[] { 79 }, KataPrimeFactors.Factorize(79));

            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2, 5 }, KataPrimeFactors.Factorize(80));
            CollectionAssert.AreEqual(new int[] { 3, 3, 3, 3 }, KataPrimeFactors.Factorize(81));
            CollectionAssert.AreEqual(new int[] { 2, 41 }, KataPrimeFactors.Factorize(82));
            CollectionAssert.AreEqual(new int[] { 83 }, KataPrimeFactors.Factorize(83));
            CollectionAssert.AreEqual(new int[] { 2, 2, 3, 7 }, KataPrimeFactors.Factorize(84));
            CollectionAssert.AreEqual(new int[] { 5, 17 }, KataPrimeFactors.Factorize(85));
            CollectionAssert.AreEqual(new int[] { 2, 43 }, KataPrimeFactors.Factorize(86));
            CollectionAssert.AreEqual(new int[] { 3, 29 }, KataPrimeFactors.Factorize(87));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 11 }, KataPrimeFactors.Factorize(88));
            CollectionAssert.AreEqual(new int[] { 89 }, KataPrimeFactors.Factorize(89));

            CollectionAssert.AreEqual(new int[] { 2, 3, 3, 5 }, KataPrimeFactors.Factorize(90));
            CollectionAssert.AreEqual(new int[] { 7, 13 }, KataPrimeFactors.Factorize(91));
            CollectionAssert.AreEqual(new int[] { 2, 2, 23 }, KataPrimeFactors.Factorize(92));
            CollectionAssert.AreEqual(new int[] { 3, 31 }, KataPrimeFactors.Factorize(93));
            CollectionAssert.AreEqual(new int[] { 2, 47 }, KataPrimeFactors.Factorize(94));
            CollectionAssert.AreEqual(new int[] { 5, 19 }, KataPrimeFactors.Factorize(95));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2, 2, 3 }, KataPrimeFactors.Factorize(96));
            CollectionAssert.AreEqual(new int[] { 97 }, KataPrimeFactors.Factorize(97));
            CollectionAssert.AreEqual(new int[] { 2, 7, 7 }, KataPrimeFactors.Factorize(98));
            CollectionAssert.AreEqual(new int[] { 3, 3, 11 }, KataPrimeFactors.Factorize(99));
            CollectionAssert.AreEqual(new int[] { 2, 2, 5, 5 }, KataPrimeFactors.Factorize(100));
        }
    }
}
