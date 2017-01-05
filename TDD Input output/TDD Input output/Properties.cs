using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Input_output
{
    class Properties
    {
        string firstName;
        public string FirstNameProp
        {
            get { return firstName; }
            set
            {
                if (value.Contains("!") || value.Contains("<") || value.Contains(">") || value.Contains("@") || value.Contains("#"))
                    firstName = "invalid name";
                else if (value.Contains("1") || value.Contains("2") || value.Contains("3") || value.Contains("4") || value.Contains("5"))
                    firstName = "invalid name";
                else firstName = value;
            }
        }

        string lastName;
        public string LastNameProp
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
        public string FilenameProp
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
    }
}
