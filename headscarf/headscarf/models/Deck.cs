using universitycollege.solitaire.model;
using System;
using System.Collections.Generic;

namespace universitycollege.solitaire.model
{
    /// <summary>
    /// Deck class
    /// </summary>
    public class Deck
    {
        private List<Card> _cardDeck = new List<Card>();

        public List<Card> CardDeck
        {
            get { return _cardDeck; }
            set { _cardDeck = value; }
        }

        public Deck(int ShuffleCount) 
        {
            CreateDefaultDesk();
            this.Shuffle(ShuffleCount);
        }

        /// <summary>
        /// A method for shuffling cards
        /// </summary>
        /// <param name="ShuffleCount">Number of complete shuffles (54) of the deck</param>
        public void Shuffle(int ShuffleCount)
        {
            Random rnd = new Random();

            for (int countShuffle = 0; countShuffle < ShuffleCount; countShuffle++)
            {
                for (int countCard = _cardDeck.Count - 1; countCard >= 0; countCard--)
                {
                    int RandomNumber = rnd.Next(countCard);
                    Card temp = _cardDeck[countCard];
                    _cardDeck[countCard] = _cardDeck[RandomNumber];
                    _cardDeck[RandomNumber] = temp;
                }
            }
        }

        /// <summary>
        /// Сreating a base deck where all the denominators of the suit go sequentially in order
        /// </summary>
        public void CreateDefaultDesk()
        {
            for (byte denominatorOfCard = (int)Card.CardNamesEnum.DEUCE; denominatorOfCard <= (int)Card.CardNamesEnum.ACE; denominatorOfCard++)
            {
                for (byte suit = 1; suit <= (int)Card.SuitNamesEnum.COUNT; suit++)
                {
                    switch (suit) {
                        case 1:
                            _cardDeck.Add(new Card(denominatorOfCard, 'H')); 
                            break;
                        case 2:
                            _cardDeck.Add(new Card(denominatorOfCard, 'D'));
                            break;
                        case 3:
                            _cardDeck.Add(new Card(denominatorOfCard, 'S'));
                            break;
                        case 4:
                            _cardDeck.Add(new Card(denominatorOfCard, 'C'));
                            break;
                    }
                }
            }
        }

        public override string ToString()
        {
            string StringDesk = "";

            for (int i = 0; i < _cardDeck.Count; i++)
            {
                StringDesk += $"{_cardDeck[i].ToString()}\n";
            }

            return StringDesk;
        }

    }
}
