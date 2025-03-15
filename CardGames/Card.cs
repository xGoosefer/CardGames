using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    internal class Card
    {
        public int Value;
        public string Suit;

        public Card()
        {
            this.Value = 0;
            this.Suit = string.Empty;
        }

        public virtual string AboutCard()
        {
            return $"{Value} of {Suit}";
        }
    }
}
