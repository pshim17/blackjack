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
        }

        public bool HitOrStand()
        {
            Console.WriteLine("Press 'h' to hit or 's' to stand: ");

            while (true)
            {
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "h")
                {
                    Card playerCard = player.DrawCardFromDeck(deck);

                    Console.WriteLine($"\nyou drew: {playerCard.Rank} of {playerCard.Suit}");        
                    
                    if (player.hand.TotalCardValue() > 21)
                    {
                        Console.WriteLine("Bust! Game Over!");
                    }
                }
                else if (userInput == "s")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\nInvalid Entry");
                }
            }
        }
    }
}
