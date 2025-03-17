using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    internal class ApplesOrOranges:Game
    {
        List<Card> board = new List<Card>();
        bool isSame = false;
        FruitDeck fruitDeck = new FruitDeck();

        /* add cards to the deck so that we can see the card using the About Deck
         Plays the game */
        public void GetCardInfo()
        {
            Clear();
            fruitDeck.initDeck();
            WriteLine(fruitDeck.AboutDeck());
            WriteLine("\n \n");
            fruitDeck.ShuffleDeck();
            player.Hand.Add(fruitDeck.Draw());
            WriteLine($"You have the {player.Hand[0].AboutCard()}. \n");
            IsSameSuit();
            ReadKey();
        }

        public void IsSameSuit()
        {
            player.points = 0;
            for(int p = player.points; p < 10; )
            {
                WriteLine("Will the next card be the same suit or different suit? \n" +
                    "For same suit type: same \n" +
                    "For different suit type: different \n");
                switch (ReadLine())
                {
                    case "same":
                        isSame = true;
                        break;
                    case "different":
                        isSame = false;
                        break;
                    default:
                        WriteLine($"Please enter one of the options explained above. \n");
                        IsSameSuit();
                        break;
                }
                board.Add(fruitDeck.Draw());
                WriteLine($"The next card is the {board[0].AboutCard()} \n");
                if (player.Hand[0].Suit == board[0].Suit && isSame == true) 
                {
                    WriteLine("You guessed correctly! You gained a point! \n");
                    p++;
                    WriteLine($"You now have {p} points! \n");

                }
                else if (player.Hand[0].Suit == board[0].Suit && isSame == false)
                {
                    WriteLine("You guessed wrong! \n");
                    WriteLine($"You still have {p} points! \n");
                }

            }
        }
    }
}