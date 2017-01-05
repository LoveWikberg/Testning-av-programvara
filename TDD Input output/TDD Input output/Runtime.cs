using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Input_output
{
    class Runtime
    {
        UI ui = new UI();

        public void Start()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("[1] Create a text file.");
                Console.WriteLine("[2] Exit.");

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        ui.GetInputs();
                        break;
                    case ConsoleKey.D2:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
