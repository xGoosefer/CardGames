using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGames
{
    public class Game
    {
        protected string Instructions;
        

        public void Play()
        {
            Console.WriteLine("Please choose a game you would like to play.");
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}