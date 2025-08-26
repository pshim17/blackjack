using System.Reflection;

namespace blackjack;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Blackjack!");

        while (true)
        {
            Game game = new Game();
            game.start();
            Console.WriteLine("Play again? (y/n)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "n")
            {
                break;
            } else if (userInput == "y")
            {
                continue;
            } else
            {
                Console.WriteLine("Invalid Entry!");
                continue;
            }
        }
        Console.WriteLine("Good bye!");
    }
}