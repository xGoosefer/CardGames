using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    internal class HighestMatch:Game
    {
        private string Suits;

        private int Value;
        private int Rounds;

        public void GetCardInfo()
        {
            
            FrenchDeck frenchDeck = new FrenchDeck();
            frenchDeck.initDeck();
            WriteLine(frenchDeck.AboutDeck());
            WriteLine("\n Shufflled Deck \n");
            frenchDeck.ShuffleDeck();
            WriteLine($"Congratulations! \n This game is currently not finished. \n \n Press any key to continue.");
            ReadKey();
            Clear();
            Play();
        }

        public void AdvanceRound()
        {
            throw new System.NotImplementedException();
        }

        public void PlayRound()
        {
            throw new System.NotImplementedException();
        }
    }
}