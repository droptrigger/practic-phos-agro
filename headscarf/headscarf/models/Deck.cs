using System;
using System.Collections.Generic;

namespace headscarf.models
{
    /// <summary>
    /// Класс колоды
    /// </summary>
    public class Deck
    {
        private List<Card> _cardDeck;

        public List<Card> CardDeck => _cardDeck;

        public Deck() 
        {
            _cardDeck = Create();
            this.Shuffle();
        }

        public void Shuffle()
        {
            Random rng = new Random();

            for (int i = 0; i <= 3; i++)
            {
                int n = _cardDeck.Count;
                while (n > 1)
                {
                    int k = rng.Next(n--);
                    Card temp = _cardDeck[n];
                    _cardDeck[n] = _cardDeck[k];
                    _cardDeck[k] = temp;
                }
            }      
        }

        public List<Card> Create()
        {
            List<Card> temp = new List<Card>();
            for (byte i = 1; i <= 13; i++)
            {
                for (byte j = 1; j <= 4; j++)
                {
                    switch (j) {
                        case 1:
                            temp.Add(new Card(i, 'H'));
                            break;
                        case 2:
                            temp.Add(new Card(i, 'D'));
                            break;
                        case 3:
                            temp.Add(new Card(i, 'S'));
                            break;
                        case 4:
                            temp.Add(new Card(i, 'C'));
                            break;
                    }
                }
            }
            return temp;
        }

        public string GetString()
        {
            string temp = "";

            for (int i = 0; i < _cardDeck.Count; i++)
            {
                temp += _cardDeck[i].GetInfo() + "\n";
            }

            return temp;
        }
    }
}
