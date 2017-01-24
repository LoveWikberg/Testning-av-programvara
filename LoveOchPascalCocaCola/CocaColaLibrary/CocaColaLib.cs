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

        #region Bad stuff
        //public string Convert(string input)
        //{
        //    if (input.All(c => c >= 1 && c <= 100))
        //    {

        //    }
        //    else
        //        throw new Exception();
        //}

        //public string ConvertThreeToCoca(int threeToCoca)
        //{
        //    //string coca = threeToCoca.ToString();

        //    //Refactored
        //    string coca = "Coca";
        //    for (threeToCoca = 1; threeToCoca <= 100; threeToCoca++)
        //    {
        //        if (threeToCoca % 3 == 0)
        //            Console.WriteLine(coca);
        //        else
        //            Console.WriteLine(threeToCoca);
        //    }
        //    return coca;
        //}

        //public string ConvertFiveToCola(int fiveToCola)
        //{
        //    //string cola = fiveToCola.ToString();
        //    string Cola = "Cola";
        //    for (fiveToCola= 1; fiveToCola<= 100; fiveToCola++)
        //    {
        //        if (fiveToCola% 5 == 0)
        //            Console.WriteLine(cola);
        //        else
        //            Console.WriteLine(fiveToCola);
        //    }
        //    return cola;
        //}

        //public string ConvertThreeAndFiveToCocaCola(int threeToCoca, int fiveToCola)
        //{
        //    //string coca = threeToCoca.ToString();
        //    //string cola = fiveToCola.ToString();

        //    string coca = "Coca";
        //    string cola = "Cola";
        //    string cocaCola = coca + cola;

        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //            Console.WriteLine(cola);
        //        else
        //            Console.WriteLine(i);
        //    }
        //    return cola;
        //}
        #endregion

    }
}
