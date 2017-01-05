using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void CheckFileExist_Expectedtrue()
        {
            Class1 test = new Class1();
            string fileName = "textfil";
            string directory = Directory.GetCurrentDirectory();
            bool expectedBool = true;   

            Assert.AreEqual(expectedBool, test.TextFileExist(fileName));
        }

        [TestMethod]
        public void Filename_Invalid()
        {
            Class1 test = new Class1();
            string filename = "\\@:@";
            string expectedOutput = "invalid filename";
            Assert.AreEqual(expectedOutput, test.FilenameHandler(filename));
        }

        [TestMethod]
        public void Filename_Valid()
        {
            Class1 test = new Class1();
            string filename = "file";
            string expectedOutput = filename;
            Assert.AreEqual(expectedOutput, test.FilenameHandler(filename));
        }

        [TestMethod]
        public void Firstname_Valid()
        {
            Class1 test = new Class1();
            string firstName = "sten";
            string expectedOutput = "sten";
            Assert.AreEqual(expectedOutput, test.FirstNameHandler(firstName));
        }

        [TestMethod]
        public void FirstName_Should_Be_Invalid_Due_To_Invalid_Character()
        {
            Class1 test = new Class1();
            string firstName = "Fjop!!¤¤¤876**pe";
            string expectedOutput = "invalid name";
            Assert.AreEqual(expectedOutput, test.FirstNameHandler(firstName));
        }

        [TestMethod]
        public void Invalid_If_Lastname_Contain_Space()
        {
            Class1 test = new Class1();
            string lastName = "wik berg";
            string expextedOutput = "invalid name";
            Assert.AreEqual(expextedOutput, test.LastNameHandler(lastName));
        }

        [TestMethod]
        public void Lastname_Valid()
        {
            Class1 test = new Class1();
            string lastName = "Tjoppe";
            
            Assert.AreEqual(lastName, test.LastNameHandler(lastName));
        }

        [TestMethod]
        public void Addition_FIVEDOTFOUR_SIXDOTSIX_TWELVE()
        {
            Class1 test = new Class1();
            double num1 = 5.4;
            double num2 = 6.6;
            Assert.AreEqual(12, test.Addition(num1, num2));
        }

        [TestMethod]
        public void Subtraction_FIVE_ZERODOTFIVE_FOURDOTFIVE()
        {
            Class1 test = new Class1();
            double num1 = 5;
            double num2 = 0.5;
            Assert.AreEqual(4.5, test.Subtraction(num1, num2));
        }

        [TestMethod]
        public void Multiplication_FIVE_ZERODOTFIVE_TWODOTFIVE()
        {
            Class1 test = new Class1();
            double num1 = 5;
            double num2 = 0.5;
            Assert.AreEqual(2.5, test.Multiplication(num1, num2));
        }

        [TestMethod]
        public void Division_FIVE_ZERODOTFIVE_TEN()
        {
            Class1 test = new Class1();
            double num1 = 5;
            double num2 = 0.5;
            Assert.AreEqual(10, test.Division(num1, num2));
        }   

    }
}
