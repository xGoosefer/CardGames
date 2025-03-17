using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    public class ApplesOrOranges:Game
    {
        private string Suits;
        private int Value;

        // add cards to the deck so that we can see the card using the About Deck
        public void GetCardInfo()
        {
            FruitDeck fruitDeck = new FruitDeck();
            fruitDeck.initDeck();
            WriteLine(fruitDeck.AboutDeck());
            WriteLine("\n Shufflled Deck \n");
            fruitDeck.ShuffleDeck();
        }

        public void IsSameSuit()
        {
            throw new System.NotImplementedException();
        }
    }
}