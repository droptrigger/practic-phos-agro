using universitycollege.solitaire.data;
using System;

namespace universitycollege.solitaire.model
{
    /// <summary>
    /// Card class
    /// </summary>
    public class Card
    {
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

        private bool _isUpside = false;
        private byte _denominatorOfCard;
        private char _suit;

        public int DenominatorOfCard => _denominatorOfCard;
        public char Suit => _suit;

        
        public Card(byte denminator, char suit)
        {
            if (denminator < (int)CardNamesEnum.MIN || denminator > (int)CardNamesEnum.MAX)
            {
                throw new Exception("Mistake! There is no such card.");
            }

            _denominatorOfCard = denminator;
            _suit = suit;
        }

        /// <summary>
        /// The method that turns the card over on the table
        /// </summary>
        public void Upside()
        {
            _isUpside = !_isUpside;
        }

        public override string ToString()
        {
            if (_isUpside)
            {
                return InMemory.CardNames[_denominatorOfCard] + " " + InMemory.SuitNames[_suit] + " ! IS UPSIDE";
            }

            else
            {
                return InMemory.CardNames[_denominatorOfCard] + " " + InMemory.SuitNames[_suit];
            }
        }
    }
}
