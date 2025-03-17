using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    internal class Deck
    {
        
        // Get deck of cards ready
        protected List<Card> cards;
        protected string[] suits;
        protected int deckSize;
        List<Card> shuffle;


        // customizable properties from different decks
        public Deck()
        {
            cards = new List<Card>();
            suits = [];
            deckSize = 12;
        }

        // adds cards to deck
        public void initDeck()
        {
            for (int i = 0; i < deckSize; i++)
            {

                foreach (string s in suits)
                    AddCard(i, s);
            }
        }

        // creates a card
        protected virtual void AddCard(int value, string suit)
        {
            cards.Add(new Card()
            {
                Value = value,
                Suit = suit,
            });
        }

        public virtual string AboutDeck()
        {
            string about = string.Empty;
            foreach (Card card in cards)
            {
                about += card.AboutCard() + "\n";
            }
            return about.Trim();
        }

        
        // The method used to shuffled the cards inside the List of Cards
             List<Card> Shuffle(List<Card> unshuffled)
            {
                unshuffled = cards;
                Random randomNum = new Random();
                return unshuffled.OrderBy(a => randomNum.Next()).ToList();
            }
        // This only reveals the selected deck of shuffled cards.
        public virtual void ShuffleDeck()
        {
            shuffle = Shuffle(cards);
            //foreach (Card card in shuffle)
            //{
            //    Console.WriteLine(card.AboutCard());
            //}
            //Console.ReadKey();
        }
        // Draw the top card from the shuffled deck and remove it from the deck.
        public Card Draw()
        {
            Card card = shuffle[0];
            shuffle.Remove(card);
            return card;
        }

    }
}
