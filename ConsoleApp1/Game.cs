using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;


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
            Thread.Sleep(800);
            Console.WriteLine("Done! \n");
            Thread.Sleep(500);
            var sortedCards = cards.OrderBy(n => Guid.NewGuid());

            return sortedCards.ToList();
        }

        public void Print5Cards(List<Card> cards)
        {
            Thread.Sleep(800);
            Console.WriteLine("Hmm... The first five cards in the deck is: \n");
            Thread.Sleep(800);
            var printing5cards = cards.Take(5).ToList();
            foreach (var i in printing5cards)
            {
                i.PrintCards();
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        public void PrintOlderThenTen(List<Card> cards)
        {
            Thread.Sleep(800);
            Console.WriteLine("All cards with rank over then Ten: \n");
            Thread.Sleep(800);
            var after10 = cards.Where(x => x.Rank > Rank.Ten);
           
            foreach (var i in after10)
            {
                i.PrintCards();
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }


        public void PrintAllClubs(List<Card> cards)
        {
            Thread.Sleep(800);
            Console.WriteLine("And noooow!.. Watch the magic)))) All club cards in the deck: \n");
            Thread.Sleep(800);
            var clubs = cards.Where(x => x.Suit == Suit.Clubs).ToList();
            foreach (var i in clubs)
            {
                i.PrintCards();
            }
            
        }

    }

}

