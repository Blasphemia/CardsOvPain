using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace DeckOfCards
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Game game = new Game();
            var item = game.MakingTheDeckOfCards();
            item = game.SortTheDeck(item);
            game.Print5Cards(item);
            game.PrintOlderThenTen(item);
            game.PrintAllClubs(item);
            Console.ReadLine();


        }
    }
}