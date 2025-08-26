using System.Reflection;

namespace blackjack;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Blackjack!");
        Console.WriteLine("Press any key to play");
        Console.ReadKey(true);

        while (true)
        {
            Game game = new Game();
            game.Start();

            while(true)
            {
                Console.WriteLine("\nPlay again? (y/n)");
                
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "n")
                {
                    Console.WriteLine("\nGood bye!");
                    return;
                }
                else if (userInput == "y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid Entry!");
                }
            }
        }
    }
}