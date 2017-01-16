using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystemConverter;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThreeShouldBeIII()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = 3;
            string expectedOutput = "III";
            Assert.AreEqual(expectedOutput, test.ConvertToRomanNumeral(input));
        }

        [TestMethod]
        public void HoundredShouldBeC()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = 100;
            string expectedOutput = "C";
            Assert.AreEqual(expectedOutput, test.ConvertToRomanNumeral(input));
        }

        [TestMethod]
        public void OneThousandThirtySixShouldBeMXXXVI()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = 1036;
            string expectedOutput = "MXXXVI";
            Assert.AreEqual(expectedOutput, test.ConvertToRomanNumeral(input));
        }

        [TestMethod]
        public void SixHoundredSevenShouldBeDCVII()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = 607;
            string expectedOutput = "DCVII";
            Assert.AreEqual(expectedOutput, test.ConvertToRomanNumeral(input));
        }

        [TestMethod]
        public void TwoThousandFiftyShouldBeMML()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = 2050;
            string expectedOutput = "MML";
            Assert.AreEqual(expectedOutput, test.ConvertToRomanNumeral(input));
        }

        [TestMethod]
        public void OneShouldBeI()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = 1;
            string expectedOutput = "I";
            Assert.AreEqual(expectedOutput, test.ConvertToRomanNumeral(input));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ZeroShouldBeException()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = 0;
            test.ConvertToRomanNumeral(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void BadNumberShouldBeException()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = -00000000;
            test.ConvertToRomanNumeral(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NegativeIntShouldBeException()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = -3;
            test.ConvertToRomanNumeral(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IfInputIsHigherThan_3001_Exception()
        {
            RomanNumeralConverter test = new RomanNumeralConverter();
            int input = 3005;
            test.ConvertToRomanNumeral(input);
        }


    }
}
