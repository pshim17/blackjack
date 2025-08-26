using System.Reflection;

namespace blackjack;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Blackjack!");

        while (true)
        {
            Deck deck = new Deck();
            Player player = new Player();
            Dealer dealer = new Dealer();

            Card firstCardPlayer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"You drew: {firstCardPlayer.Rank} of {firstCardPlayer.Suit}");

            Card firstCardDealer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"dealer drew: {firstCardDealer.Rank} of {firstCardDealer.Suit}");

            Card secondCardPlayer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"You drew: {secondCardPlayer.Rank} of {secondCardPlayer.Suit}");

            Card secondCardDealer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"dealer drew: {secondCardDealer.Rank} of {secondCardDealer.Suit}");

            Console.WriteLine("Player’s hand now has:");

            foreach (Card card in player.hand.DisplayCards())
            {
                Console.WriteLine($" - {card.Rank} of {card.Suit}" +
                    $"(value {card.Value})");
            }

            Console.WriteLine("Dealer’s hand now has:");

            foreach (Card card in dealer.hand.DisplayCards())
            {
                Console.WriteLine($" - {card.Rank} of {card.Suit}" +
                    $"(value {card.Value})");
            }

            int totalPlayer = player.hand.TotalCardValue();
            int totalDealer = dealer.hand.TotalCardValue();

            Console.WriteLine($"player total: {totalPlayer}");
            Console.WriteLine($"dealer total: {totalDealer}");

            Console.WriteLine("Play again? (y/n)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "n")
            {
                break;
            } else if (userInput == "y")
            {
                continue;
            }
        }
        Console.WriteLine("Good bye!");
    }
}