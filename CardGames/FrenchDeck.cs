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
            suits = [ "Diamonds", "Hearts", "Clubs", "Spades" ];

            
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
