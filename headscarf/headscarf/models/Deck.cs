using System.Collections.Generic;

namespace headscarf.models
{
    public class Deck
    {
        private List<Card> _cardDeck;

        public List<Card> CardDeck { get { return _cardDeck; } }

        public Deck() 
        {
            _cardDeck = Create();
            this.Shuffle();
        }

        public void Shuffle()
        {
            // TODO: Make shuffle
        }

        public List<Card> Create()
        {
            List<Card> temp = new List<Card>();
            for (byte i = 2; i <= 14; i++)
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
    }
}
