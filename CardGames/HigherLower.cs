using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    public class HigherLower : Game
    {
        private string Suits;

        private int Value;

        public void GetCardInfo()
        {

            FrenchDeck frenchDeck = new FrenchDeck();
            frenchDeck.initDeck();
            WriteLine(frenchDeck.AboutDeck());

        }

        public void IsHigherorLower()
        {
            throw new System.NotImplementedException();
        }
    }
}