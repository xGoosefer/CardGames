using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    public class Game
    {
        protected string Instructions;
        

        public void Play()
        {
            WriteLine("Please choose a game you would like to play. \n" +
                "1: Apples and Oranges \n" +
                "2: Higher or Lower");

            switch (ReadLine())
            {
                case "1":
                    WriteLine("CHOSEN");
                    break;
                default:
                    WriteLine($"Please enter a number corresponding to an option in the list.");
                    break;
            }
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}