using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGames
{
    public class Player:PersonPlayer
    {
        private int Points;

        public void Discard()
        {
            throw new System.NotImplementedException();
        }
    }

    public class PersonPlayer
    {
        private int Points;
        

    }

    public class Dealer:PersonPlayer
    {
    }
}