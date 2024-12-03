using System.Collections.Generic;

namespace headscarf.models
{
    /// <summary>
    /// Класс карт
    /// </summary>
    public class Card
    {
        private static readonly Dictionary<int, string> cardNames = new Dictionary<int, string>
        {
            { 1, "ACE" },
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
            { 13, "KING" }
        };

        private static readonly Dictionary<char, string> suitNames = new Dictionary<char, string>
        {
            { 'H', "HEARTS" },
            { 'D', "DIAMONDS" },
            { 'S', "SPADES" },
            { 'C', "CLUBS" }
        };

        private bool _isTop = false;
        private bool _isUpside = false; 
        private byte _num;
        private char _suit;

        public int Num => _num;
        public char Suit => _suit;

        private byte[] _position = 
        {
            0, // Столбец
            0  // Строка
        };

        private byte[] _topPosition = 
        { 
            0, // Столбец
            0  // Счет
        };

        public byte[] Position { get { return _position; } }


        public Card(byte num, char suit)
        {
            _num = num;
            _suit = suit;
        }

        public void UpdatePosition(byte row, byte col) 
        {
            _position[0] = row;
            _position[1] = col;
        }

        public void UpdateTopPosition(byte position)
        {
            _topPosition[1] = position;
            _isTop = true;
        }

        public void Upside()
        {
            _isUpside = true;
        }

        public string GetInfo()
        {
            if (_isUpside)
                return cardNames[_num] + " " + suitNames[_suit] + " ! IS UPSIDE";
            return cardNames[_num] + " " + suitNames[_suit];
        }

    }
}
