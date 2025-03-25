using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CardGames
{
    internal class HigherLower : Game
    {
        List<Card> board = new List<Card>();
        bool isSame = false;
        bool isHigher = false;
        FrenchDeck frenchDeck = new FrenchDeck();
        public void GetCardInfo()
        {
            player.points = 0;
            Clear();
            frenchDeck.initDeck();
            WriteLine("Cards in this deck! \n");
            WriteLine(frenchDeck.AboutDeck());
            frenchDeck.ShuffleDeck();
            player.Hand.Add(frenchDeck.Draw());
            WriteLine($"You have the {player.Hand[0].AboutCard()}. \n");
            IsHigherorLower();
            ReadKey();
            Clear(); ;
            Play();
        }

        public void IsHigherorLower()
        {
            for (int p = player.points; p < 10;)
            {

                WriteLine("Will the value of the next card be higher, lower or the same? \n" +
                    "For same value type: same \n" +
                    "For higher value type: higher \n" +
                    "For lower value type: lower ");
                switch (ReadLine())
                {
                    case "same":
                        isSame = true;
                        break;
                    case "higher":
                        isHigher = true;
                        break;
                    case "lower":
                        isHigher = false;
                        break;
                    default:
                        WriteLine($"Please enter one of the options explained above. \n");
                        IsHigherorLower();
                        break;
                }
                board.Add(frenchDeck.Draw());
                WriteLine($"The next card is the {board[0].AboutCard()} \n");
                if (player.Hand[0].Value == board[0].Value && isSame == true)
                {
                    WriteLine("You guessed correctly! You gained a point! \n");
                    p++;
                    player.points++;
                    WriteLine($"You now have {p} points! \n");

                }
                else if (player.Hand[0].Value != board[0].Value && isSame == true)
                {
                    WriteLine("You guessed wrong! \n");
                    WriteLine($"You still have {p} points! \n");
                }
                if (player.Hand[0].Value == board[0].Value && isSame == false)
                {
                    WriteLine("You guessed wrong! \n");
                    WriteLine($"You still have {p} points! \n");

                }
                else if (player.Hand[0].Value > board[0].Value && isHigher == false)
                {
                    WriteLine("You guessed correctly! You gained a point! \n");
                    p++;
                    player.points++;
                    WriteLine($"You now have {p} points! \n");
                }
                else if (player.Hand[0].Value < board[0].Value && isHigher == false)
                {
                    WriteLine("You guessed wrong! \n");
                    WriteLine($"You still have {p} points! \n");
                }
                else if (player.Hand[0].Value < board[0].Value && isHigher == true)
                {
                    WriteLine("You guessed correctly! You gained a point! \n");
                    p++;
                    player.points++;
                    WriteLine($"You now have {p} points! \n");
                }
                else
                {
                    WriteLine("You guessed wrong! \n");
                    WriteLine($"You still have {p} points! \n");
                }
                WriteLine("Press any key to continue.");
                player.Hand.Remove(player.Hand[0]);
                board.Remove(board[0]);
                ReadKey();
                Clear();
                //if the deck runs out of cards, reshuffle the deck.
                if (frenchDeck.shuffle.Count > 0)
                {
                    player.Hand.Add(frenchDeck.Draw());
                }
                else
                {
                    frenchDeck.ShuffleDeck();
                    player.Hand.Add(frenchDeck.Draw());
                }
                WriteLine($"You have the {player.Hand[0].AboutCard()}. \n");
                isSame = false;

            }
            WriteLine($"Congratulations! You earned {player.points} points! You won the game! \n \n Press any key to continue.");
        }
    }
}