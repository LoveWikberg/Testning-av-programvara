﻿using System;
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

                foreach (var ran in ListClass.rank)
                {
                    if (rank == ran.Input)
                    {
                        rank = ran.Card;
                        break;
                    }
                }
                foreach (var col in ListClass.color)
                {
                    if (color == col.Input)
                    {
                        color = col.Card;
                        break;
                    }
                }

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