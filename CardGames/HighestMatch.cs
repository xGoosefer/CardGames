﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    public class HighestMatch:Game
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