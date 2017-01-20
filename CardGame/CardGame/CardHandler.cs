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
            try
            {
                char[] charArray = input.ToLower().ToCharArray();

                if (charArray.Length > 2 && !input.Contains("10"))
                    throw new Exception("Too long...");

                string rank = charArray[0].ToString();
                string color = charArray[1].ToString();
                if (input.Length > 2)
                {
                    rank += charArray[1].ToString();
                    color = charArray[2].ToString();
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

                // If the variables "rank" or "color" has the same value before and after the foreach-loops,
                // throw an exception.
                if (rank == charArray[0].ToString() || color == charArray[1].ToString())
                    throw new Exception("Card does not excist...");
                else
                    return rank + " of " + color;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
