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

        public void start()
        {
            Card firstCardPlayer = player.DrawCardFromDeck(deck);
            Card secondCardPlayer = player.DrawCardFromDeck(deck);

            Card firstCardDealer = dealer.DrawCardFromDeck(deck);
            Card secondCardDealer = dealer.DrawCardFromDeck(deck);

            Console.WriteLine($"\nYou drew: {firstCardPlayer.Rank} of {firstCardPlayer.Suit}");
            Console.WriteLine($"You drew: {secondCardPlayer.Rank} of {secondCardPlayer.Suit}\n");
            Console.WriteLine($"dealer drew: ?? of ??");
            Console.WriteLine($"dealer drew: {secondCardDealer.Rank} of {secondCardDealer.Suit}\n");

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
                    Console.WriteLine($"Your current total is: {player.hand.TotalCardValue()}\n");
                    
                    if (player.hand.TotalCardValue() > 21)
                    {
                        return;
                    }
                }
                else if (userInput == "s")
                {
                    string dealerHiddenCardRank = dealer.hand.cards[0].Rank;
                    string dealerHiddenCardSuit = dealer.hand.cards[0].Suit;

                    Console.WriteLine($"\nDealer's hidden card was: {dealerHiddenCardRank} of {dealerHiddenCardSuit}");

                    while (dealer.hand.TotalCardValue() < 17)
                    {
                        Card dealerCard = dealer.DrawCardFromDeck(deck);
                        Console.WriteLine($"\ndealer drew: {dealerCard.Rank} of {dealerCard.Suit}");
                    }

                    Console.WriteLine($"\ndealer final total: {dealer.hand.TotalCardValue()}");
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
            if (player.hand.TotalCardValue() > 21)
            {
                Console.WriteLine("Bust! Dealer Wins!");
            }
        }
    }
}
