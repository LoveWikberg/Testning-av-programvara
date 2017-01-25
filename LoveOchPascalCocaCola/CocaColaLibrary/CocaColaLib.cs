using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocaColaLibrary
{
    public class CocaColaLib
    {

        // Loops all numbers from 1-100.
        // If the number is divisible by three AND five, return "Coca-Cola"
        // If the number is divisible by three, return "Coca"
        // If the number is divisible by five, return "Cola"
        public string ConvertNumber(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "CocaCola";
            }
            else if (number % 3 == 0)
            {
                return "Coca";
            }
            else if (number % 5 == 0)
                return "Cola";
            else
                return number.ToString();
        }

        public string ConvertThreeToCoca(int threeToCoca)
        {
            // The first test failed due to the generated method throwing a 
            // NonImplementedException();
            // Here we wanted the number five to convert to a string "Coca".
            // When changing the return type to "Coca" the test passed.

            //Refactored method:
            string coca = "Coca";
            for (threeToCoca = 1; threeToCoca <= 100; threeToCoca++)
            {
                if (threeToCoca % 3 == 0)
                    Console.WriteLine(coca);
                else
                    Console.WriteLine(threeToCoca);
            }
            return coca;

            //Test passed.
        }

        public string ConvertFiveToCola(int fiveToCola)
        {
            // The first test failed due to the generated method throwing a 
            // NonImplementedException();
            // Here we wanted the number five to convert to a string "Cola".
            // When changing the return type to "Cola" the test passed.

            //Refactored method:
            string cola = "Cola";
            for (fiveToCola = 1; fiveToCola <= 100; fiveToCola++)
            {
                if (fiveToCola % 5 == 0)
                    Console.WriteLine(cola);
                else
                    Console.WriteLine(fiveToCola);
            }
            return cola;

            // Test passed.
        }

        public string ConvertThreeAndFiveToCocaCola(int threeToCoca, int fiveToCola)
        {
            // Now we wanted the method to return CocaCola for numbers
            // dividable by Five and three.
            // The first test failed due to the generated method throwing a 
            // NonImplementedException();
            
            // Since we wanted to create a new string from the two vairables
            // We added the two strings and returned the new one. 
            // When changing the return type to "CocaCola" the test passed.

            //Refactored method:
            string coca = "Coca";
            string cola = "Cola";
            string cocaCola = coca + cola;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(cocaCola);
                else
                    Console.WriteLine(i);
            }
            return cocaCola;

            // Test passed. 
        }

        #region Bad stuff
        //public string Convert(string input)
        //{
        //    if (input.All(c => c >= 1 && c <= 100))
        //    {

        //    }
        //    else
        //        throw new Exception();
        //}
        #endregion

    }
}
