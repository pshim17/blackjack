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
            Hand hand = new Hand();

            Card firstCard = player.DrawCardFromDeck(deck);
            Console.WriteLine($"You drew: {firstCard.Rank} of {firstCard.Suit}");
            hand.AddtoHand(firstCard);

            Card secondCard = player.DrawCardFromDeck(deck);
            Console.WriteLine($"You drew: {secondCard.Rank} of {secondCard.Suit}");
            hand.AddtoHand(secondCard);

            Console.WriteLine("Player’s hand now has:");

            foreach (Card card in player.hand.DisplayCards())
            {
                Console.WriteLine($" - {card.Rank} of {card.Suit}" +
                    $"(value {card.Value})");
            }

            int total = hand.TotalCardValue();
            Console.WriteLine(total);

            Console.WriteLine("Play again? (y/n)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "n")
            {
                break;
            }
        }
        Console.WriteLine("Good bye!");
    }
}