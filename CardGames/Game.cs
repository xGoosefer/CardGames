using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    internal class Game
    {
        //protected string Instructions;
        public Player player = new Player();

        public void Play()
        {
            WriteLine("Please choose a game you would like to play. \n" +
                "1: Apples and Oranges \n" +
                "2: Higher or Lower \n" +
                "3: Highest Match");

            switch (ReadLine())
            {
                case "1":
                    ApplesOrOranges();
                    break;
                case "2":
                    HigherLower();
                    break;
                case "3":
                    HighestMatch();
                    break;
                default:
                    WriteLine($"Please enter a number corresponding to an option in the list.");
                    break;
            }

            Play();
        }

       

        public void ApplesOrOranges()
        {
            
            new ApplesOrOranges().GetCardInfo();
        }

        public void HighestMatch()
        {
            
            new HighestMatch().GetCardInfo();
        }

        public void HigherLower()
        {
            
            new HigherLower().GetCardInfo();
        }
    }
}