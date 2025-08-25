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
            Hand playerHand = new Hand();
            Hand dealerHand = new Hand();

            Card firstCardPlayer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"You drew: {firstCardPlayer.Rank} of {firstCardPlayer.Suit}");
            playerHand.AddtoHand(firstCardPlayer);

            Card firstCardDealer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"dealer drew: {firstCardDealer.Rank} of {firstCardDealer.Suit}");
            dealerHand.AddtoHand(firstCardDealer);

            Card secondCardPlayer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"You drew: {secondCardPlayer.Rank} of {secondCardPlayer.Suit}");
            playerHand.AddtoHand(secondCardPlayer);

            Card secondCardDealer = player.DrawCardFromDeck(deck);
            Console.WriteLine($"dealer drew: {secondCardDealer.Rank} of {secondCardDealer.Suit}");
            dealerHand.AddtoHand(secondCardDealer);

            Console.WriteLine("Player’s hand now has:");

            foreach (Card card in playerHand.DisplayCards())
            {
                Console.WriteLine($" - {card.Rank} of {card.Suit}" +
                    $"(value {card.Value})");
            }

            Console.WriteLine("Dealer’s hand now has:");

            foreach (Card card in dealerHand.DisplayCards())
            {
                Console.WriteLine($" - {card.Rank} of {card.Suit}" +
                    $"(value {card.Value})");
            }

            int totalPlayer = playerHand.TotalCardValue();
            int totalDealer = dealerHand.TotalCardValue();

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