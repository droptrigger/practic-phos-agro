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

        public enum CardNamesEnum
        {
            MIN = 2,
            MAX = 14,

            DEUCE = 2,
            TREY = 3,
            FOUR = 4,
            FIVE = 5,
            SIX = 6,
            SEVEN = 7,
            EIGHT = 8,
            NINE = 9,
            TEN = 10,
            JACK = 11,
            QUEEN = 12,
            KING = 13,
            ACE = 14
        }

        public enum SuitNamesEnum
        {
            HEARTS = 1,
            DIAMONDS = 2,
            SPADES = 3,
            CLUBS = 4,

            COUNT = 4
        }
    }
}
