using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace DeckOfCards
{
    public class Game

    {

        public List<Card> MakingTheDeckOfCards()
        {
            List<Card> deckOfCards = new List<Card>();

            foreach (var suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (var rank in (Rank[])Enum.GetValues(typeof(Rank)))
                {
                    Card card = new Card() { Suit = suit, Rank = rank };

                    deckOfCards.Add(card);
                }

            }

            return deckOfCards;
        }


        public List<Card> SortTheDeck(List<Card> cards)
        {
            
            Console.WriteLine("Now we shuffle the deck...  \n");
            Thread.Sleep(1000);
            Console.WriteLine("Done!");
            Thread.Sleep(1000);
            var sortedCards = cards.OrderBy(n => Guid.NewGuid());

            return sortedCards.ToList();
        }

        public void Print5Cards(List<Card> cards)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hmm... The first five cards in the deck is: \n");
            Thread.Sleep(1000);
            var printing5cards = cards.Take(5).ToList();
            foreach (var i in printing5cards)
            {
                i.PrintCards();
            }

        }

        public void PrintOlderThenTen(List<Card> cards)
        {
            Thread.Sleep(1000);
            Console.WriteLine("All cards with rank over then ten");
            Thread.Sleep(1000);
            var after10 = cards.Where(x => x.Rank > Rank.Ten);
           
            foreach (var i in after10)
            {
                i.PrintCards();
            }

        }


        public void PrintAllClubs(List<Card> cards)
        {
            Thread.Sleep(1000);
            Console.WriteLine("And noooow!.. Watch the magic)))) All club cards in the deck :)");
            Thread.Sleep(1000);
            var clubs = cards.Where(x => x.Suit == Suit.Clubs).ToList();
            foreach (var i in clubs)
            {
                i.PrintCards();
            }

        }

    }

}

