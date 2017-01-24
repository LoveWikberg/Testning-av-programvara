using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class CardHandler
    {
        public string ConvertToCard(string input)
        {
            if (input.Length > 2 && !input[0].Equals('1') || input.Length.Equals(0) || input.Length > 3 || input.Length.Equals(1))
                return "Too long or too short...";

            else
            {
                string rank = input[0].ToString();
                string color = input[1].ToString();

                // If input contains "10" (input[0] = 1 and input[1] = 0) change "rank" and "color" value.
                if (input.Contains("10"))
                {
                    rank += input[1].ToString();
                    color = input[2].ToString();
                }

                foreach (var card in ListClass.rank)
                {
                    if (rank == card.CompareInput)
                    {
                        rank = card.Card;
                        break;
                    }
                }
                foreach (var card in ListClass.color)
                {
                    if (color == card.Input)
                    {
                        color = card.Card;
                        break;
                    }
                }

                // If the variables "rank" or "color" has the same value before and after the foreach-loops -
                // throw an exeption.
                if (rank == input[0].ToString() || color == input[1].ToString())
                    return "Card does not exist...";
                else
                    return rank + " of " + color;
            }
        }
    }
}
