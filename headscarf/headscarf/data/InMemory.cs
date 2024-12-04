using System.Collections.Generic;

namespace universitycollege.solitaire.data
{
    public class InMemory
    {
        public static readonly Dictionary<int, string> CardNames = new Dictionary<int, string>
        {
            { 2, "DEUCE" },
            { 3, "TREY" },
            { 4, "FOUR" },
            { 5, "FIVE" },
            { 6, "SIX" },
            { 7, "SEVEN" },
            { 8, "EIGHT" },
            { 9, "NINE" },
            { 10, "TEN" },
            { 11, "JACK" },
            { 12, "QUEEN" },
            { 13, "KING" },
            { 14, "ACE" }
        };

        public static readonly Dictionary<char, string> SuitNames = new Dictionary<char, string>
        {
            { 'H', "HEARTS" },
            { 'D', "DIAMONDS" },
            { 'S', "SPADES" },
            { 'C', "CLUBS" }
        };
    }
}
