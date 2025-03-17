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
            this.deckSize = 13;
            suits = ["Apples", "Oranges"];
        }
        public override string AboutDeck()
        {
            string about = string.Empty;
            foreach (Card card in cards)
            {
                about += card.AboutCard() + "\n";
            }
            return about.Trim();
        }
    }
}
