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

            Console.WriteLine($"You drew: {firstCardPlayer.Rank} of {firstCardPlayer.Suit}");
            Console.WriteLine($"You drew: {secondCardPlayer.Rank} of {secondCardPlayer.Suit}\n");
            Console.WriteLine($"dealer drew: ?? of ??");
            Console.WriteLine($"dealer drew: {secondCardDealer.Rank} of {secondCardDealer.Suit}\n");

            HitOrStand();
        }

        public void HitOrStand()
        {
            while(true)
            {
                Console.WriteLine("Press 'h' to hit or 's' to stay: ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "h")
                {
                    player.DrawCardFromDeck(deck);
                    break;
                }
            }
        }
    }
}
