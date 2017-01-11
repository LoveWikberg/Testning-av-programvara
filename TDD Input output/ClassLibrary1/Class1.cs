using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Class1
    {
        string firstName;
        string FirstNameProp
        {
            get { return firstName; }
            set
            {
                if (value.Contains("!") || value.Contains("<") || value.Contains(">") || value.Contains("@") || value.Contains("#"))
                    throw new Exception("invalid name contains symbols");
                //firstName = "invalid name";
                else if (value.Contains("1") || value.Contains("2") || value.Contains("3") || value.Contains("4") || value.Contains("5"))
                    throw new Exception("invalid name contains numbers");
                    //firstName = "invalid name";
                else firstName = value;
            }
        }
        string lastName;
        string LastNameProp
        {
            get { return lastName; }
            set
            {
                if (value.Contains(" "))
                    lastName = "invalid name";
                else lastName = value;
            }
        }
        string filename;
        string FilenameProp
        {
            get { return filename; }
            set
            {
                if (value.Contains("@") || value.Contains("\\") || value.Contains(";") || value.Contains(":") || value.Contains("/"))
                    filename = "invalid filename";
                else
                    filename = value;
            }
        }

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
            FilenameProp = input;
            return FilenameProp;
        }

        public string FirstNameHandler(string input)
        {
            FirstNameProp = input;
            return FirstNameProp;
        }

        public string LastNameHandler(string input)
        {
            LastNameProp = input;
            return LastNameProp;
        }

        public double Addition(double firstNum, double secondNum)
        {
            double result = firstNum + secondNum;
            return result;
        }

        public double Subtraction(double firstNum, double secondNum)
        {
            double result = firstNum - secondNum;
            return result;
        }

        public double Multiplication(double firstNum, double secondNum)
        {
            double result = firstNum * secondNum;
            return result;
        }

        public double Division(double firstNum, double secondNum)
        {
            double result = firstNum / secondNum;
            return result;
        }
    }
}
