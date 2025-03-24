using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGames
{
    internal class Player 
    {
        // Oh yeah, it's their hand
        public List<Card> Hand = new List<Card>();
        public int points;
    }

}