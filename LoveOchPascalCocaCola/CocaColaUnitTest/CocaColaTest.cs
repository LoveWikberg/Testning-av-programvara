﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CocaColaLibrary;

namespace CocaColaUnitTest
{
    [TestClass]
    public class CocaColaTest
    {
        [TestMethod]
        public void Int_Three_Should_ConvertTo_Coca()
        {
            CocaColaLib lib = new CocaColaLib();

            int number = 3;
            string expectedOutput = "Coca";
            string actualOutput = lib.ConvertNumber(number);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Int_Five_Should_ConvertTo_Cola()
        {
            CocaColaLib lib = new CocaColaLib();

            int number = 5;
            string expectedOutput = "Cola";
            string actualOuput = lib.ConvertNumber(number);

            Assert.AreEqual(expectedOutput, actualOuput);
        }

        [TestMethod]
        public void Int_Fifteen_Should_Convert_To_CocaCola()
        {
            CocaColaLib lib = new CocaColaLib();

            int number = 15;
            string expectedOutput = "CocaCola";
            string actualOutput = lib.ConvertNumber(number);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Int_Eleven_Should_Be_Eleven()
        {
            CocaColaLib lib = new CocaColaLib();

            int number = 11;
            string expectedOutput = "11";
            string actualOutput = lib.ConvertNumber(number);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

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
    }
}
