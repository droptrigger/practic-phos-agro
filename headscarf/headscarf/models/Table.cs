using System;
using System.Collections.Generic;

namespace headscarf.models
{
    public class Table
    {
        private Deck _tableDeck;
        private List<List<Card>> _tableCards = new List<List<Card>>();

        public Deck TableDeck
        {
            get { return _tableDeck; }
            set { _tableDeck = value; }
        }

        public List<List<Card>> TableCards => _tableCards;

        public void InitializeTable(Deck deck)
        {
            TableDeck = deck;

            for (byte i = 1; i <= 8; i++)
            {
                byte n = 0;
                List<Card> TempCards = new List<Card>();

                while (n < i)
                {
                    if (n == i - 1)
                        TableDeck.CardDeck[n].Upside();

                    TempCards.Add(TableDeck.CardDeck[n]);
                    TableDeck.CardDeck.RemoveAt(n);
                    n++;
                }

                _tableCards.Add(TempCards);
            }
        }

        public string GetTable()
        {
            string temp = "";

            foreach (List<Card> card in TableCards)
            {
                for (int i = 0; i < card.Count; i++)
                {
                    temp += card[i].GetInfo() + "\n";
                }
                temp += "\n";
            }

            return temp;
        }
    }
}
