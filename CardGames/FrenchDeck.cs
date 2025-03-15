using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    internal class FrenchDeck : Deck
    {
        public FrenchDeck()
        {
            this.deckSize = 13;
            suits = new string[] { "Diamonds", "Hearts", "Clubs", "Spades" };

            initDeck();
        }

        
    }
}
