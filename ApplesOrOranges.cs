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
            player.points = 0;
            Clear();
            fruitDeck.initDeck();
            WriteLine("Cards in this deck! \n");
            WriteLine(fruitDeck.AboutDeck());
            fruitDeck.ShuffleDeck();
            player.Hand.Add(fruitDeck.Draw());
            WriteLine($"You have the {player.Hand[0].AboutCard()}. \n");
            IsSameSuit();
            ReadKey();
            Play();
        }
        
        public void IsSameSuit()
        {
            
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
                        player.points++;
                        WriteLine($"You now have {p} points! \n");

                    }
                    else if (player.Hand[0].Suit == board[0].Suit && isSame == false)
                    {
                        WriteLine("You guessed wrong! \n");
                        WriteLine($"You still have {p} points! \n");
                    }
                    else if (player.Hand[0].Suit != board[0].Suit && isSame == false)
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
                if (fruitDeck.shuffle.Count > 0)
                {
                    player.Hand.Add(fruitDeck.Draw());
                }
                else
                {
                    fruitDeck.ShuffleDeck();
                    player.Hand.Add(fruitDeck.Draw());
                }
                    WriteLine($"You have the {player.Hand[0].AboutCard()}. \n");
                
                
            }

            WriteLine($"Congratulations! You earned {player.points} points! You won the game!");
        }
    }
}