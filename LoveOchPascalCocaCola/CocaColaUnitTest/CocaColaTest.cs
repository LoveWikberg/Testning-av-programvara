using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CocaColaLibrary;

namespace CocaColaUnitTest
{   
    //TODO
    // 1. Test a number that is divisible by three but not by five or three and five. 
    // 2. Test a number that is divisible by five but not by three or three and five. 
    // 3. Test a number that is divisible by three and five but not by three alone or five alone. 
    // 4. Test a number that is not divisible by three, five or three and five. 

    [TestClass]
    public class CocaColaTest
    {
        [TestMethod]
        public void Int_Nine_Should_ConvertTo_Coca()
        {
            // First we created this test method to check if the number returned the
            // right string. In this case we chose int 9 as an input, which should
            // return a string "Coca". Since no method existed we generated a new 
            // one in out CocaColaLib-class which automatically threw a NonImplemented 
            // exception. When refactored the method returned the string "Coca".

            CocaColaLib lib = new CocaColaLib();

            int number = 9;
            string expectedOutput = "Coca";
            string actualOutput = lib.ConvertThreeToCoca(number);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Int_Twenty_Should_ConvertTo_Cola()
        {
            // First we created this test method to check if the number returned the
            // right string. In this case we chose int 20 as an input, which should
            // return a string "Coca". We generated a method in the CocaColaLib-class which 
            // automatically threw a NonImplementedException. 

            // When refactored the method returned the string "Cola".

            CocaColaLib lib = new CocaColaLib();

            int number = 20;
            string expectedOutput = "Cola";
            string actualOuput = lib.ConvertFiveToCola(number);

            Assert.AreEqual(expectedOutput, actualOuput);
        }

        [TestMethod]
        public void Three_And_Five_Shoudld_ConvertTo_CocaCola()
        {
            // First we created this test method to check if the number returned the
            // right string. In this case we chose int 3 and int 5 as inputs, which should
            // return a string "CocaCola". We generated a method in the CocaColaLib-class which 
            // automatically threw a NonImplementedException. 

            // When refactored the method returned the string "Cola".

            CocaColaLib lib = new CocaColaLib();

            int threeToCoca = 3;
            int fiveToCola = 5;

            string expectedOutput = "CocaCola";
            string actualOutput = lib.ConvertThreeAndFiveToCocaCola(threeToCoca, fiveToCola);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Int_Fifteen_Should_Convert_To_CocaCola()
        {
            // Here we wanted to test that the number 15 returned CocaCola
            // Here we generated a new convert method which we would use
            // as the coverter in the final program.
            // The refactored method returned "CocaCola".
             

            CocaColaLib lib = new CocaColaLib();

            int number = 15;
            string expectedOutput = "CocaCola";
            string actualOutput = lib.ConvertNumber(number);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Int_Eleven_Should_Be_Eleven()
        {
            // Here we wanted to test if a number which isn't dividable
            // by three or five still returns the correct output. 
            // We used our converter method for this test. 

            CocaColaLib lib = new CocaColaLib();

            int number = 11;
            string expectedOutput = "11";
            string actualOutput = lib.ConvertNumber(number);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        #region bad stuff
        //[TestMethod]
        //public void Int_Three_And_Int_Three_Should_ConvertTo_CocaCola()
        //{
        //    CocaColaLib lib = new CocaColaLib();

        //    int threeToCoca= 3;
        //    int fiveToCola= 5;

        //    string expectedOutput = "CocaCola";
        //    string actualOuput = lib.ConvertThreeAndFiveToCocaCola(threeToCoca, fiveTocola);

        //    Assert.AreEqual(expectedOutput, actualOuput);
        //}
        #endregion
    }
}
