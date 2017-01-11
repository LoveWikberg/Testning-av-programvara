using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TDD_Input_output
{
    class Client
    {
        Properties prop = new Properties();
        string directory = Directory.GetCurrentDirectory();

        public bool TextFileExist(string fileName)
        {
            string directory = Directory.GetCurrentDirectory();
            if (!File.Exists(directory + "\\" + fileName + ".txt"))
            {
                return false;
            }
            else
                return true;
        }

        public string FilenameHandler(string input)
        {
            prop.FilenameProp = input;
            return prop.FilenameProp;
        }

        public string FirstNameHandler(string input)
        {
            prop.FirstNameProp = input;
            return prop.FirstNameProp;
        }

        public string LastNameHandler(string input)
        {
            prop.LastNameProp = input;
            return prop.LastNameProp;
        }

        double Addition(double firstNum, double secondNum)
        {
            double result = firstNum + secondNum;
            return result;
        }

        double Subtraction(double firstNum, double secondNum)
        {
            double result = firstNum - secondNum;
            return result;
        }

        double Multiplication(double firstNum, double secondNum)
        {
            double result = firstNum * secondNum;
            return result;
        }

        double Division(double firstNum, double secondNum)
        {
            double result = firstNum / secondNum;
            return result;
        }

        public void WriteToFile(double num1, double num2, string firstName, string lastName, string fileName)
        {
            string name = "Name: " + FirstNameHandler(firstName);
            string last = "Lastname: " + LastNameHandler(lastName);

            //Makes the ecvations readable in the textfile.
            string addEcvation = num1.ToString() + " + " + num2.ToString() + " = " + Addition(num1, num2).ToString();
            string subEcvation = num1.ToString() + " - " + num2.ToString() + " = " + Subtraction(num1, num2).ToString();
            string multiEcvation = num1.ToString() + " * " + num2.ToString() + " = " + Multiplication(num1, num2).ToString();
            string divEcvation = num1.ToString() + " / " + num2.ToString() + " = " + Division(num1, num2).ToString();

            //Saves all the strings above in one string
            string fileContent = name + Environment.NewLine + last + Environment.NewLine
                + addEcvation + Environment.NewLine + subEcvation + Environment.NewLine
                + multiEcvation + Environment.NewLine + divEcvation + Environment.NewLine;

            if (!TextFileExist(fileName))
                File.WriteAllText(directory + "\\" + fileName + ".txt", fileContent);
            else
                File.AppendAllText(directory + "\\" + fileName + ".txt", fileContent);
        }
    }
}
