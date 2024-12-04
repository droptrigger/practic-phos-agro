using universitycollege.solitaire.data;
using System;

namespace universitycollege.solitaire.model
{
    /// <summary>
    /// Card class
    /// </summary>
    public class Card
    {
        private bool _isUpside = false;
        private byte _denominatorOfCard;
        private char _suit;

        public int DenominatorOfCard => _denominatorOfCard;
        public char Suit => _suit;

        
        public Card(byte denminator, char suit)
        {
            if (denminator < (int)InMemory.CardNamesEnum.MIN || denminator > (int)InMemory.CardNamesEnum.MAX)
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
