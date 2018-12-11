﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace DeckOfCards
{
    public class Card

    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }



        public string CardsRank(Rank item)
        {
            string rank = "";

            switch (item)
            {
                case Rank.Two:
                    rank = "2";
                    break;
                case Rank.Three:
                    rank = "3";
                    break;
                case Rank.Four:
                    rank = "4";
                    break;
                case Rank.Five:
                    rank = "5";
                    break;
                case Rank.Six:
                    rank = "6";
                    break;
                case Rank.Seven:
                    rank = "7";
                    break;
                case Rank.Eight:
                    rank = "8";
                    break;
                case Rank.Nine:
                    rank = "9";
                    break;
                case Rank.Ten:
                    rank = "10";
                    break;
                case Rank.Jack:
                    rank = "J";
                    break;
                case Rank.Queen:
                    rank = "Q";
                    break;
                case Rank.King:
                    rank = "K";
                    break;
                case Rank.Ace:
                    rank = "A";
                    break;
            }
            
            return rank;

        }
        public string CardSuit(Suit cardsuit)
        {
            string suit = "";

            switch (cardsuit)
            {
                case Suit.Clubs:

                    suit = "♣";
                    break;
                case Suit.Diamonds:
                   
                    suit = "♦";
                    break;
                case Suit.Hearts:
                    suit = "♥";
                    break;
                case Suit.Spades:
                    suit = "♠";
                    break;
            }
            
            return suit;

        }



        public void PrintCards()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Card card = new Card();

           
                Console.WriteLine("|||||||||||||||");
                Console.WriteLine($"|{card.CardSuit(Suit)}{card.CardsRank(Rank)}           |");
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine($"|             |");
                }
                Console.WriteLine($"|           {card.CardSuit(Suit)}{card.CardsRank(Rank)}|");
                Console.WriteLine($"|||||||||||||||\n");
            Console.WriteLine("\n");


        }

    }
}