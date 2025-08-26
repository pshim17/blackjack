using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Game
    {
        public void start()
        {
            Deck deck = new Deck();
            Player player = new Player();
            Dealer dealer = new Dealer();

            Card firstCardPlayer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"You drew: {firstCardPlayer.Rank} of {firstCardPlayer.Suit}");

            Card firstCardDealer = dealer.DrawCardFromDeck(deck);
            Console.WriteLine($"dealer drew: ?? of ??");

            Card secondCardPlayer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"You drew: {secondCardPlayer.Rank} of {secondCardPlayer.Suit}");

            Card secondCardDealer = dealer.DrawCardFromDeck(deck);
            Console.WriteLine($"dealer drew: {secondCardDealer.Rank} of {secondCardDealer.Suit}");


            //int totalPlayer = player.hand.TotalCardValue();
            //int totalDealer = dealer.hand.TotalCardValue();

            //Console.WriteLine($"player total: {totalPlayer}");
            //Console.WriteLine($"dealer total: {totalDealer}");
        }
    }
}
