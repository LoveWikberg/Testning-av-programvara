using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveOchPascalCocaCola
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(ConvertNumber(i));
            }
            Console.ReadKey();
        }

        static string ConvertNumber(int number)
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
    }
}
