using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    internal class FruitDeck : Deck
    {
        public FruitDeck()
        {
            this.deckSize = 10;
            suits = new string[] { "Apples", "Oranges" };
        }
        
    }
}
