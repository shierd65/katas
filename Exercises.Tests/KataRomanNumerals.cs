using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTest
    {
        [TestMethod]
        public void NumbersToRomanNumeralsTests()
        {
            Assert.AreEqual("I", KataRomanNumerals.NumberToRomanNumerals(1));
            Assert.AreEqual("II", KataRomanNumerals.NumberToRomanNumerals(2));
            Assert.AreEqual("III", KataRomanNumerals.NumberToRomanNumerals(3));
            Assert.AreEqual("IV", KataRomanNumerals.NumberToRomanNumerals(4));
            Assert.AreEqual("V", KataRomanNumerals.NumberToRomanNumerals(5));
            Assert.AreEqual("VI", KataRomanNumerals.NumberToRomanNumerals(6));
            Assert.AreEqual("VII", KataRomanNumerals.NumberToRomanNumerals(7));
            Assert.AreEqual("VIII", KataRomanNumerals.NumberToRomanNumerals(8));
            Assert.AreEqual("IX", KataRomanNumerals.NumberToRomanNumerals(9));

            Assert.AreEqual("X", KataRomanNumerals.NumberToRomanNumerals(10));
            Assert.AreEqual("XI", KataRomanNumerals.NumberToRomanNumerals(11));
            Assert.AreEqual("XII", KataRomanNumerals.NumberToRomanNumerals(12));
            Assert.AreEqual("XIII", KataRomanNumerals.NumberToRomanNumerals(13));
            Assert.AreEqual("XIV", KataRomanNumerals.NumberToRomanNumerals(14));
            Assert.AreEqual("XV", KataRomanNumerals.NumberToRomanNumerals(15));
            Assert.AreEqual("XVI", KataRomanNumerals.NumberToRomanNumerals(16));
            Assert.AreEqual("XVII", KataRomanNumerals.NumberToRomanNumerals(17));
            Assert.AreEqual("XVIII", KataRomanNumerals.NumberToRomanNumerals(18));
            Assert.AreEqual("XIX", KataRomanNumerals.NumberToRomanNumerals(19));

            Assert.AreEqual("XX", KataRomanNumerals.NumberToRomanNumerals(20));
            Assert.AreEqual("XXI", KataRomanNumerals.NumberToRomanNumerals(21));
            Assert.AreEqual("XXII", KataRomanNumerals.NumberToRomanNumerals(22));
            Assert.AreEqual("XXIII", KataRomanNumerals.NumberToRomanNumerals(23));
            Assert.AreEqual("XXIV", KataRomanNumerals.NumberToRomanNumerals(24));
            Assert.AreEqual("XXV", KataRomanNumerals.NumberToRomanNumerals(25));
            Assert.AreEqual("XXVI", KataRomanNumerals.NumberToRomanNumerals(26));
            Assert.AreEqual("XXVII", KataRomanNumerals.NumberToRomanNumerals(27));
            Assert.AreEqual("XXVIII", KataRomanNumerals.NumberToRomanNumerals(28));
            Assert.AreEqual("XXIX", KataRomanNumerals.NumberToRomanNumerals(29));

            Assert.AreEqual("XXX", KataRomanNumerals.NumberToRomanNumerals(30));
            Assert.AreEqual("XXXI", KataRomanNumerals.NumberToRomanNumerals(31));
            Assert.AreEqual("XXXII", KataRomanNumerals.NumberToRomanNumerals(32));
            Assert.AreEqual("XXXIII", KataRomanNumerals.NumberToRomanNumerals(33));
            Assert.AreEqual("XXXIV", KataRomanNumerals.NumberToRomanNumerals(34));
            Assert.AreEqual("XXXV", KataRomanNumerals.NumberToRomanNumerals(35));
            Assert.AreEqual("XXXVI", KataRomanNumerals.NumberToRomanNumerals(36));
            Assert.AreEqual("XXXVII", KataRomanNumerals.NumberToRomanNumerals(37));
            Assert.AreEqual("XXXVIII", KataRomanNumerals.NumberToRomanNumerals(38));
            Assert.AreEqual("XXXIX", KataRomanNumerals.NumberToRomanNumerals(39));

            Assert.AreEqual("XL", KataRomanNumerals.NumberToRomanNumerals(40));
            Assert.AreEqual("XLI", KataRomanNumerals.NumberToRomanNumerals(41));
            Assert.AreEqual("XLII", KataRomanNumerals.NumberToRomanNumerals(42));
            Assert.AreEqual("XLIII", KataRomanNumerals.NumberToRomanNumerals(43));
            Assert.AreEqual("XLIV", KataRomanNumerals.NumberToRomanNumerals(44));
            Assert.AreEqual("XLV", KataRomanNumerals.NumberToRomanNumerals(45));
            Assert.AreEqual("XLVI", KataRomanNumerals.NumberToRomanNumerals(46));
            Assert.AreEqual("XLVII", KataRomanNumerals.NumberToRomanNumerals(47));
            Assert.AreEqual("XLVIII", KataRomanNumerals.NumberToRomanNumerals(48));
            Assert.AreEqual("XLIX", KataRomanNumerals.NumberToRomanNumerals(49));

            Assert.AreEqual("L", KataRomanNumerals.NumberToRomanNumerals(50));
            Assert.AreEqual("LI", KataRomanNumerals.NumberToRomanNumerals(51));
            Assert.AreEqual("LII", KataRomanNumerals.NumberToRomanNumerals(52));
            Assert.AreEqual("LIII", KataRomanNumerals.NumberToRomanNumerals(53));
            Assert.AreEqual("LIV", KataRomanNumerals.NumberToRomanNumerals(54));
            Assert.AreEqual("LV", KataRomanNumerals.NumberToRomanNumerals(55));
            Assert.AreEqual("LVI", KataRomanNumerals.NumberToRomanNumerals(56));
            Assert.AreEqual("LVII", KataRomanNumerals.NumberToRomanNumerals(57));
            Assert.AreEqual("LVIII", KataRomanNumerals.NumberToRomanNumerals(58));
            Assert.AreEqual("LIX", KataRomanNumerals.NumberToRomanNumerals(59));

            Assert.AreEqual("LX", KataRomanNumerals.NumberToRomanNumerals(60));
            Assert.AreEqual("LXXI", KataRomanNumerals.NumberToRomanNumerals(71));
            Assert.AreEqual("LXXXII", KataRomanNumerals.NumberToRomanNumerals(82));
            Assert.AreEqual("LXIII", KataRomanNumerals.NumberToRomanNumerals(63));
            Assert.AreEqual("LXXIV", KataRomanNumerals.NumberToRomanNumerals(74));
            Assert.AreEqual("LXXXV", KataRomanNumerals.NumberToRomanNumerals(85));
            Assert.AreEqual("LXVI", KataRomanNumerals.NumberToRomanNumerals(66));
            Assert.AreEqual("LXXVII", KataRomanNumerals.NumberToRomanNumerals(77));
            Assert.AreEqual("LXXXVIII", KataRomanNumerals.NumberToRomanNumerals(88));
            Assert.AreEqual("LXIX", KataRomanNumerals.NumberToRomanNumerals(69));

            Assert.AreEqual("XCIII", KataRomanNumerals.NumberToRomanNumerals(93));
            Assert.AreEqual("XCIX", KataRomanNumerals.NumberToRomanNumerals(99));
            Assert.AreEqual("CLXXXII", KataRomanNumerals.NumberToRomanNumerals(182));
            Assert.AreEqual("CCLXIII", KataRomanNumerals.NumberToRomanNumerals(263));
            Assert.AreEqual("CCCLXXIV", KataRomanNumerals.NumberToRomanNumerals(374));
            Assert.AreEqual("CDLXXXV", KataRomanNumerals.NumberToRomanNumerals(485));
            Assert.AreEqual("CCLXVI", KataRomanNumerals.NumberToRomanNumerals(266));
            Assert.AreEqual("CDLXXVII", KataRomanNumerals.NumberToRomanNumerals(477));
            Assert.AreEqual("CLXXXVIII", KataRomanNumerals.NumberToRomanNumerals(188));
            Assert.AreEqual("CCCXCIX", KataRomanNumerals.NumberToRomanNumerals(399));

            Assert.AreEqual("DXCIII", KataRomanNumerals.NumberToRomanNumerals(593));
            Assert.AreEqual("DCXCIX", KataRomanNumerals.NumberToRomanNumerals(699));
            Assert.AreEqual("DCCLXXXII", KataRomanNumerals.NumberToRomanNumerals(782));
            Assert.AreEqual("DCCCLXIII", KataRomanNumerals.NumberToRomanNumerals(863));
            Assert.AreEqual("DLXXIV", KataRomanNumerals.NumberToRomanNumerals(574));
            Assert.AreEqual("DCLXXXV", KataRomanNumerals.NumberToRomanNumerals(685));
            Assert.AreEqual("DCCLXVI", KataRomanNumerals.NumberToRomanNumerals(766));
            Assert.AreEqual("DCCCLXXVII", KataRomanNumerals.NumberToRomanNumerals(877));
            Assert.AreEqual("DLXXXVIII", KataRomanNumerals.NumberToRomanNumerals(588));
            Assert.AreEqual("DCXCIX", KataRomanNumerals.NumberToRomanNumerals(699));
            Assert.AreEqual("CMXCIX", KataRomanNumerals.NumberToRomanNumerals(999));
            Assert.AreEqual("CMXLVII", KataRomanNumerals.NumberToRomanNumerals(947));
            Assert.AreEqual("CMXXX", KataRomanNumerals.NumberToRomanNumerals(930));

            Assert.AreEqual("MDCXCIX", KataRomanNumerals.NumberToRomanNumerals(1699));
            Assert.AreEqual("MMDCCLXXXII", KataRomanNumerals.NumberToRomanNumerals(2782));
            Assert.AreEqual("MMMDCCCLXIII", KataRomanNumerals.NumberToRomanNumerals(3863));
            Assert.AreEqual("MDLXXIV", KataRomanNumerals.NumberToRomanNumerals(1574));
            Assert.AreEqual("MMDCLXXXV", KataRomanNumerals.NumberToRomanNumerals(2685));
            Assert.AreEqual("MMMDCCLXVI", KataRomanNumerals.NumberToRomanNumerals(3766));
        }

        [TestMethod]
        public void RomanNumeralsToNumbersTests()
        {
            Assert.AreEqual(1, KataRomanNumerals.RomanNumeralsToNumbers("I"));
            Assert.AreEqual(2, KataRomanNumerals.RomanNumeralsToNumbers("II"));
            Assert.AreEqual(3, KataRomanNumerals.RomanNumeralsToNumbers("III"));
            Assert.AreEqual(4, KataRomanNumerals.RomanNumeralsToNumbers("IV"));
            Assert.AreEqual(5, KataRomanNumerals.RomanNumeralsToNumbers("V"));
            Assert.AreEqual(6, KataRomanNumerals.RomanNumeralsToNumbers("VI"));
            Assert.AreEqual(7, KataRomanNumerals.RomanNumeralsToNumbers("VII"));
            Assert.AreEqual(8, KataRomanNumerals.RomanNumeralsToNumbers("VIII"));
            Assert.AreEqual(9, KataRomanNumerals.RomanNumeralsToNumbers("IX"));

            Assert.AreEqual(10, KataRomanNumerals.RomanNumeralsToNumbers("X"));
            Assert.AreEqual(11, KataRomanNumerals.RomanNumeralsToNumbers("XI"));
            Assert.AreEqual(12, KataRomanNumerals.RomanNumeralsToNumbers("XII"));
            Assert.AreEqual(13, KataRomanNumerals.RomanNumeralsToNumbers("XIII"));
            Assert.AreEqual(14, KataRomanNumerals.RomanNumeralsToNumbers("XIV"));
            Assert.AreEqual(15, KataRomanNumerals.RomanNumeralsToNumbers("XV"));
            Assert.AreEqual(16, KataRomanNumerals.RomanNumeralsToNumbers("XVI"));
            Assert.AreEqual(17, KataRomanNumerals.RomanNumeralsToNumbers("XVII"));
            Assert.AreEqual(18, KataRomanNumerals.RomanNumeralsToNumbers("XVIII"));
            Assert.AreEqual(19, KataRomanNumerals.RomanNumeralsToNumbers("XIX"));

            Assert.AreEqual(20, KataRomanNumerals.RomanNumeralsToNumbers("XX"));
            Assert.AreEqual(21, KataRomanNumerals.RomanNumeralsToNumbers("XXI"));
            Assert.AreEqual(22, KataRomanNumerals.RomanNumeralsToNumbers("XXII"));
            Assert.AreEqual(23, KataRomanNumerals.RomanNumeralsToNumbers("XXIII"));
            Assert.AreEqual(24, KataRomanNumerals.RomanNumeralsToNumbers("XXIV"));
            Assert.AreEqual(25, KataRomanNumerals.RomanNumeralsToNumbers("XXV"));
            Assert.AreEqual(26, KataRomanNumerals.RomanNumeralsToNumbers("XXVI"));
            Assert.AreEqual(27, KataRomanNumerals.RomanNumeralsToNumbers("XXVII"));
            Assert.AreEqual(28, KataRomanNumerals.RomanNumeralsToNumbers("XXVIII"));
            Assert.AreEqual(29, KataRomanNumerals.RomanNumeralsToNumbers("XXIX"));

            Assert.AreEqual(30, KataRomanNumerals.RomanNumeralsToNumbers("XXX"));
            Assert.AreEqual(31, KataRomanNumerals.RomanNumeralsToNumbers("XXXI"));
            Assert.AreEqual(32, KataRomanNumerals.RomanNumeralsToNumbers("XXXII"));
            Assert.AreEqual(33, KataRomanNumerals.RomanNumeralsToNumbers("XXXIII"));
            Assert.AreEqual(34, KataRomanNumerals.RomanNumeralsToNumbers("XXXIV"));
            Assert.AreEqual(35, KataRomanNumerals.RomanNumeralsToNumbers("XXXV"));
            Assert.AreEqual(36, KataRomanNumerals.RomanNumeralsToNumbers("XXXVI"));
            Assert.AreEqual(37, KataRomanNumerals.RomanNumeralsToNumbers("XXXVII"));
            Assert.AreEqual(38, KataRomanNumerals.RomanNumeralsToNumbers("XXXVIII"));
            Assert.AreEqual(39, KataRomanNumerals.RomanNumeralsToNumbers("XXXIX"));

            Assert.AreEqual(40, KataRomanNumerals.RomanNumeralsToNumbers("XL"));
            Assert.AreEqual(41, KataRomanNumerals.RomanNumeralsToNumbers("XLI"));
            Assert.AreEqual(42, KataRomanNumerals.RomanNumeralsToNumbers("XLII"));
            Assert.AreEqual(43, KataRomanNumerals.RomanNumeralsToNumbers("XLIII"));
            Assert.AreEqual(44, KataRomanNumerals.RomanNumeralsToNumbers("XLIV"));
            Assert.AreEqual(45, KataRomanNumerals.RomanNumeralsToNumbers("XLV"));
            Assert.AreEqual(46, KataRomanNumerals.RomanNumeralsToNumbers("XLVI"));
            Assert.AreEqual(47, KataRomanNumerals.RomanNumeralsToNumbers("XLVII"));
            Assert.AreEqual(48, KataRomanNumerals.RomanNumeralsToNumbers("XLVIII"));
            Assert.AreEqual(49, KataRomanNumerals.RomanNumeralsToNumbers("XLIX"));

            Assert.AreEqual(50, KataRomanNumerals.RomanNumeralsToNumbers("L"));
            Assert.AreEqual(61, KataRomanNumerals.RomanNumeralsToNumbers("LXI"));
            Assert.AreEqual(72, KataRomanNumerals.RomanNumeralsToNumbers("LXXII"));
            Assert.AreEqual(83, KataRomanNumerals.RomanNumeralsToNumbers("LXXXIII"));
            Assert.AreEqual(54, KataRomanNumerals.RomanNumeralsToNumbers("LIV"));
            Assert.AreEqual(65, KataRomanNumerals.RomanNumeralsToNumbers("LXV"));
            Assert.AreEqual(76, KataRomanNumerals.RomanNumeralsToNumbers("LXXVI"));
            Assert.AreEqual(87, KataRomanNumerals.RomanNumeralsToNumbers("LXXXVII"));
            Assert.AreEqual(58, KataRomanNumerals.RomanNumeralsToNumbers("LVIII"));
            Assert.AreEqual(69, KataRomanNumerals.RomanNumeralsToNumbers("LXIX"));

            Assert.AreEqual(96, KataRomanNumerals.RomanNumeralsToNumbers("XCVI"));
            Assert.AreEqual(91, KataRomanNumerals.RomanNumeralsToNumbers("XCI"));
            Assert.AreEqual(98, KataRomanNumerals.RomanNumeralsToNumbers("XCVIII"));
            Assert.AreEqual(99, KataRomanNumerals.RomanNumeralsToNumbers("XCIX"));

            Assert.AreEqual(100, KataRomanNumerals.RomanNumeralsToNumbers("C"));
            Assert.AreEqual(121, KataRomanNumerals.RomanNumeralsToNumbers("CXXI"));
            Assert.AreEqual(142, KataRomanNumerals.RomanNumeralsToNumbers("CXLII"));
            Assert.AreEqual(133, KataRomanNumerals.RomanNumeralsToNumbers("CXXXIII"));
            Assert.AreEqual(154, KataRomanNumerals.RomanNumeralsToNumbers("CLIV"));
            Assert.AreEqual(265, KataRomanNumerals.RomanNumeralsToNumbers("CCLXV"));
            Assert.AreEqual(376, KataRomanNumerals.RomanNumeralsToNumbers("CCCLXXVI"));
            Assert.AreEqual(187, KataRomanNumerals.RomanNumeralsToNumbers("CLXXXVII"));
            Assert.AreEqual(258, KataRomanNumerals.RomanNumeralsToNumbers("CCLVIII"));
            Assert.AreEqual(369, KataRomanNumerals.RomanNumeralsToNumbers("CCCLXIX"));

            Assert.AreEqual(400, KataRomanNumerals.RomanNumeralsToNumbers("CD"));
            Assert.AreEqual(421, KataRomanNumerals.RomanNumeralsToNumbers("CDXXI"));
            Assert.AreEqual(442, KataRomanNumerals.RomanNumeralsToNumbers("CDXLII"));
            Assert.AreEqual(433, KataRomanNumerals.RomanNumeralsToNumbers("CDXXXIII"));
            Assert.AreEqual(499, KataRomanNumerals.RomanNumeralsToNumbers("CDXCIX"));
            Assert.AreEqual(500, KataRomanNumerals.RomanNumeralsToNumbers("D"));
            Assert.AreEqual(621, KataRomanNumerals.RomanNumeralsToNumbers("DCXXI"));
            Assert.AreEqual(742, KataRomanNumerals.RomanNumeralsToNumbers("DCCXLII"));
            Assert.AreEqual(833, KataRomanNumerals.RomanNumeralsToNumbers("DCCCXXXIII"));
            Assert.AreEqual(599, KataRomanNumerals.RomanNumeralsToNumbers("DXCIX"));

            Assert.AreEqual(1400, KataRomanNumerals.RomanNumeralsToNumbers("MCD"));
            Assert.AreEqual(2421, KataRomanNumerals.RomanNumeralsToNumbers("MMCDXXI"));
            Assert.AreEqual(3442, KataRomanNumerals.RomanNumeralsToNumbers("MMMCDXLII"));
            Assert.AreEqual(1433, KataRomanNumerals.RomanNumeralsToNumbers("MCDXXXIII"));
            Assert.AreEqual(2499, KataRomanNumerals.RomanNumeralsToNumbers("MMCDXCIX"));
            Assert.AreEqual(3500, KataRomanNumerals.RomanNumeralsToNumbers("MMMD"));
            Assert.AreEqual(1621, KataRomanNumerals.RomanNumeralsToNumbers("MDCXXI"));
            Assert.AreEqual(2742, KataRomanNumerals.RomanNumeralsToNumbers("MMDCCXLII"));
            Assert.AreEqual(3833, KataRomanNumerals.RomanNumeralsToNumbers("MMMDCCCXXXIII"));
            Assert.AreEqual(1599, KataRomanNumerals.RomanNumeralsToNumbers("MDXCIX"));
        }
    }
}
