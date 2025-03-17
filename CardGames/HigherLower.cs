using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    internal class HigherLower : Game
    {
        private string Suits;

        private int Value;

        public void GetCardInfo()
        {

            FrenchDeck frenchDeck = new FrenchDeck();
            frenchDeck.initDeck();
            WriteLine(frenchDeck.AboutDeck());
            WriteLine("\n Shufflled Deck \n");
            frenchDeck.ShuffleDeck();
        }

        public void IsHigherorLower()
        {
            throw new System.NotImplementedException();
        }
    }
}