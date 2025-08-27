using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Game
    {
        Deck deck = new Deck();
        Player player = new Player();
        Dealer dealer = new Dealer();

        public void Start()
        {
            Card firstCardPlayer = player.DrawCardFromDeck(deck);
            Card secondCardPlayer = player.DrawCardFromDeck(deck);

            Card firstCardDealer = dealer.DrawCardFromDeck(deck);
            Card secondCardDealer = dealer.DrawCardFromDeck(deck);

            Console.WriteLine($"\nYou drew: {firstCardPlayer.Rank} of {firstCardPlayer.Suit}");
            Console.WriteLine($"You drew: {secondCardPlayer.Rank} of {secondCardPlayer.Suit}");
            Console.WriteLine($"Your current total is: {player.Hand.TotalCardValue()}\n");

            Console.WriteLine($"dealer drew: ?? of ??");
            Console.WriteLine($"dealer drew: {secondCardDealer.Rank} of {secondCardDealer.Suit}");
            Console.WriteLine($"Dealer's total is: ??\n");

            HitOrStand();
            Outcome();
        }

        public void HitOrStand()
        {
            while (true)
            {
                Console.WriteLine("Press 'h' to hit or 's' to stand: ");

                string userInput = Console.ReadLine().ToLower();

                if (userInput == "h")
                {
                    Card playerCard = player.DrawCardFromDeck(deck);

                    Console.WriteLine($"\nyou drew: {playerCard.Rank} of {playerCard.Suit}");
                    Console.WriteLine($"Your current total is: {player.Hand.TotalCardValue()}\n");
                    
                    if (player.Hand.TotalCardValue() > 21)
                    {
                        return;
                    }
                }
                else if (userInput == "s")
                {
                    Card dealerHiddenCard = dealer.Hand.GetDealerHiddenCard();

                    Console.WriteLine($"\nDealer's hidden card was: {dealerHiddenCard.Rank} of {dealerHiddenCard.Suit}\n");

                    while (dealer.Hand.TotalCardValue() < 17)
                    {
                        Card dealerCard = dealer.DrawCardFromDeck(deck);
                        Console.WriteLine($"dealer drew: {dealerCard.Rank} of {dealerCard.Suit}");
                    }

                    Console.WriteLine($"dealer final total: {dealer.Hand.TotalCardValue()}\n");
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid Entry");
                }
            }
        }

        public void Outcome()
        {
            int playerTotal = player.Hand.TotalCardValue();
            int dealerTotal = dealer.Hand.TotalCardValue();

            if (playerTotal > 21)
            {
                RoundSummary();
                Console.WriteLine("***Bust! Dealer Wins!***");
            }
            else if (dealerTotal > 21)
            {
                RoundSummary();
                Console.WriteLine("***Dealer Bust! You Win!***");
            } else if (playerTotal > dealerTotal)
            {
                RoundSummary();
                Console.WriteLine("***You Win!***");
            } else if (playerTotal < dealerTotal)
            {
                RoundSummary();
                Console.WriteLine("***Dealer Wins!***");
            } else if (playerTotal == dealerTotal)
            {
                RoundSummary();
                Console.WriteLine("***Push! It's a Tie!***");
            }
        }

        public void RoundSummary()
        {
            Console.WriteLine("Round Summary: ");
            Console.WriteLine("You: ");

            int playerTotal = player.Hand.TotalCardValue();

            for (int i = 0; i < player.Hand.DisplayCards().Count; i++)
            {
                string cardRank = player.Hand.DisplayCards()[i].Rank;
                string cardSuit = player.Hand.DisplayCards()[i].Suit;
                Console.WriteLine($"  - {cardRank} of {cardSuit}");
            }
            Console.WriteLine($"Total: {playerTotal}\n");

            int dealerTotal = dealer.Hand.TotalCardValue();

            Console.WriteLine("Dealer: ");
            for (int i = 0; i < dealer.Hand.DisplayCards().Count; i++)
            {
                string cardRank = dealer.Hand.DisplayCards()[i].Rank;
                string cardSuit = dealer.Hand.DisplayCards()[i].Suit;
                Console.WriteLine($"  - {cardRank} of {cardSuit}");
            }
            Console.WriteLine($"Total: {dealerTotal}\n");
        }
    }
}
