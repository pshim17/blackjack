using System.Reflection;

namespace blackjack;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Blackjack!");
        Console.WriteLine("Press any key to play\n");
        Console.ReadKey(true);

        while (true)
        {
            Game game = new Game();
            game.start();

            while(true)
            {
                Console.WriteLine("Play again? (y/n)");
                
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "n")
                {
                    Console.WriteLine("Good bye!");
                    return;
                }
                else if (userInput == "y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Entry!");
                }
            }
        }
    }
}