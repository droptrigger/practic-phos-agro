﻿using System.Collections.Generic;

namespace universitycollege.solitaire.model
{
    /// <summary>
    /// Table class
    /// </summary>
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

        public Table(Deck deck)
        {
            InitializeTable(deck);
        }

        /// <summary>
        /// Laying out cards on the table from the deck
        /// </summary>
        /// <param name="deck">Link to the deck, after splitting, the cards will be removed from there</param>
        public void InitializeTable(Deck deck)
        {
            TableDeck = deck;
            byte CountCardOfRow = 0;

            for (byte NumberOfRow = 1; NumberOfRow <= 8; NumberOfRow++)
            {
                CountCardOfRow++;
                List<Card> TempCards = new List<Card>();

                for (byte NumberOfColumn = 0; NumberOfColumn < CountCardOfRow; NumberOfColumn++)
                {
                    if (NumberOfColumn == CountCardOfRow - 1)
                    {
                        TableDeck.CardDeck[NumberOfColumn].Upside();
                    }

                    TempCards.Add(TableDeck.CardDeck[NumberOfColumn]);
                    TableDeck.CardDeck.RemoveAt(NumberOfColumn);
                }

                _tableCards.Add(TempCards);
            }

            // Update main deck of card
            deck.CardDeck = TableDeck.CardDeck;
        }

        public override string ToString()
        {
            string StringTable = "";

            foreach (List<Card> card in TableCards)
            {
                for (int i = 0; i < card.Count; i++)
                {
                    StringTable += card[i].ToString() + "\n";
                }
                StringTable += "\n";
            }

            return StringTable;
        }

    }
}
