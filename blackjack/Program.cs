namespace blackjack;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Blackjack!");

        while (true)
        {
            Console.WriteLine("Play again? (y/n)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "n")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
        Console.WriteLine("Good bye!");
    }
}