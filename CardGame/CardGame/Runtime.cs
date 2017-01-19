using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Runtime
    {
        CardHandler cardHandler = new CardHandler();

        public void Menu()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                MenuOptions();
            }
        }

        void MenuOptions()
        {
            int getMenuChoice = MenuInterface.Menu(new string[3] { "Enter a number", "Run test", "Exit" });
            if (getMenuChoice == 0)
            {
                Console.Clear();
                Console.Write("Type something: ");
                string input = Console.ReadLine();
                Console.WriteLine(cardHandler.ConvertToCard(input));
                Console.ReadKey();
            }
            else if (getMenuChoice == 1)
            {
                ModuleTest mTest = new ModuleTest();
                mTest.StartTest();
                Console.ReadKey();
            }
            else if (getMenuChoice == 2)
                Environment.Exit(0);
        }
    }
}
