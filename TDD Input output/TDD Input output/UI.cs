using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace TDD_Input_output
{
    class UI
    {
        Client client = new Client();
        static string name;
        static string lastName;
        static string filename;

        public void GetInputs()
        {
            #region Get first name
            bool nameLoop = true;
            while (nameLoop)
            {
                Console.Clear();
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (client.FirstNameHandler(name) != name)
                {
                    Console.WriteLine(client.FirstNameHandler(name));
                    Console.ReadKey();
                }
                else
                    nameLoop = false;
            }
            #endregion

            #region Get last name
            bool LastNameLoop = true;
            while (LastNameLoop)
            {
                Console.Clear();
                Console.Write("Enter your last name: ");
                lastName = Console.ReadLine();
                if (client.LastNameHandler(lastName) != lastName)
                {
                    Console.WriteLine(client.LastNameHandler(lastName));
                    Console.ReadKey();
                }
                else
                    LastNameLoop = false;
            }
            #endregion

            #region Get numbers
            Console.Clear();
            Console.Write("Enter a number: ");
            double numberOne;
            bool success = double.TryParse(Console.ReadLine(), out numberOne);
            Console.Write("Enter a second number: ");
            double numberTwo;
            bool successTwo = double.TryParse(Console.ReadLine(), out numberTwo);
            #endregion

            #region Save to File
            bool FileLoop = true;
            while (FileLoop)
            {
                Console.Clear();
                Console.Write("Now it's time to save your inputs to a text file!\nGive the file a name: ");
                filename = Console.ReadLine();
                if (client.FilenameHandler(filename) != filename)
                {
                    Console.WriteLine(client.FilenameHandler(filename));
                    Console.ReadKey();
                }
                else
                    FileLoop = false;
            }

            client.WriteToFile(numberOne, numberTwo, name, lastName, filename);
            Process process = new Process();
            process.StartInfo.FileName = filename + ".txt";
            process.Start();
            #endregion
        }


    }
}
