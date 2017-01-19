using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class ListClass
    {
        public static List<Rank> rank = new List<Rank>()
        {
            new Rank {Input = "a", Card = "ace" },
            new Rank {Input = "2", Card = "two" },
            new Rank {Input = "3", Card = "three" },
            new Rank {Input = "4", Card = "four" },
            new Rank {Input = "5", Card = "five" },
            new Rank {Input = "6", Card = "six" },
            new Rank {Input = "7", Card = "seven" },
            new Rank {Input = "8", Card = "eight" },
            new Rank {Input = "9", Card = "nine" },
            new Rank {Input = "10", Card = "ten" },
            new Rank {Input = "j", Card = "jack" },
            new Rank {Input = "q", Card = "queen" },
            new Rank {Input = "k", Card = "king" },
        };

        public static List<Color> color = new List<Color>()
        {
            new Color {Input = "h", Card = "hearts" },
            new Color {Input = "c", Card = "clubs" },
            new Color {Input = "d", Card = "diamonds" },
            new Color {Input = "s", Card = "spades" }
        };
    }

    internal class Color
    {
        public string Input { get; set; }
        public string Card { get; set; }
    }

    internal class Rank
    {
        public string Input { get; set; }
        public string Card { get; set; }
    }
}
