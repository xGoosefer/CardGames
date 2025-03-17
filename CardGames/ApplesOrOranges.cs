using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    internal class ApplesOrOranges:Game
    {
        private string Suits;
        private int Value;

        /* add cards to the deck so that we can see the card using the About Deck
         Plays the game */
        public void GetCardInfo()
        {
            FruitDeck fruitDeck = new FruitDeck();
            fruitDeck.initDeck();
            WriteLine(fruitDeck.AboutDeck());
            WriteLine("\n \n");
            fruitDeck.ShuffleDeck();
            player.Hand.Add(fruitDeck.Draw());
            WriteLine($"You have the {player.Hand[0].AboutCard()}");
            ReadKey();
        }

        public void IsSameSuit()
        {
            throw new System.NotImplementedException();
        }
    }
}