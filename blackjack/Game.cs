namespace blackjack
{
    internal class Game
    {
        Deck deck = new Deck();
        Player player = new Player();
        Dealer dealer = new Dealer();

        public void Start()
        {
            Card firstCardPlayer = player.DrawCardFromDeck(deck);
            Card secondCardPlayer = player.DrawCardFromDeck(deck);

            Card firstCardDealer = dealer.DrawCardFromDeck(deck);
            Card secondCardDealer = dealer.DrawCardFromDeck(deck);

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"You drew: {firstCardPlayer.Rank} of {firstCardPlayer.Suit}");
            Console.WriteLine($"You drew: {secondCardPlayer.Rank} of {secondCardPlayer.Suit}");
            Console.WriteLine($"Your current total is: {player.Hand.TotalCardValue()}\n");

            Console.WriteLine($"Dealer drew: ?? of ??");
            Console.WriteLine($"Dealer drew: {secondCardDealer.Rank} of {secondCardDealer.Suit}");
            Console.WriteLine($"Dealer's visible card total: {secondCardDealer.Value}");

            int playerTotal = player.Hand.TotalCardValue();
            int dealerTotal = dealer.Hand.TotalCardValue();

            if (playerTotal == 21 && dealerTotal == 21)
            {
                RoundSummary();
                Console.WriteLine("***Push! It's a Tie!***");
                return;
            }
            else if (playerTotal == 21)
            {
                RoundSummary();
                Console.WriteLine("***Blackjack! You Win!***");
                return;
            }
            else if (dealerTotal == 21)
            {
                RoundSummary();
                Console.WriteLine("***Blackjack! Dealer Wins!***");
                return;
            }

            HitOrStand();
            Outcome();
        }

        public void HitOrStand()
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("Press 'h' to hit or 's' to stand: ");

                string userInput = Console.ReadLine().ToLower();

                if (userInput == "h")
                {
                    Hit();

                    if (player.Hand.TotalCardValue() > 21)
                    {
                        return;
                    }
                }
                else if (userInput == "s")
                {
                    Stand();
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid Entry");
                }
            }
        }

        public void Outcome()
        {
            int playerTotal = player.Hand.TotalCardValue();
            int dealerTotal = dealer.Hand.TotalCardValue();

            if (playerTotal > 21)
            {
                RoundSummary();
                Console.WriteLine("***Bust! Dealer Wins!***");
            }
            else if (dealerTotal > 21)
            {
                RoundSummary();
                Console.WriteLine("***Dealer Bust! You Win!***");
            } else if (playerTotal > dealerTotal)
            {
                RoundSummary();
                Console.WriteLine("***You Win!***");
            } else if (playerTotal < dealerTotal)
            {
                RoundSummary();
                Console.WriteLine("***Dealer Wins!***");
            } else if (playerTotal == dealerTotal)
            {
                RoundSummary();
                Console.WriteLine("***Push! It's a Tie!***");
            }
        }

        public void RoundSummary()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Game Summary: ");
            Console.WriteLine("You: ");

            int playerTotal = player.Hand.TotalCardValue();

            for (int i = 0; i < player.Hand.DisplayCards().Count; i++)
            {
                string cardRank = player.Hand.DisplayCards()[i].Rank;
                string cardSuit = player.Hand.DisplayCards()[i].Suit;
                Console.WriteLine($"  - {cardRank} of {cardSuit}");
            }
            Console.WriteLine($"Total: {playerTotal}\n");

            int dealerTotal = dealer.Hand.TotalCardValue();

            Console.WriteLine("Dealer: ");
            for (int i = 0; i < dealer.Hand.DisplayCards().Count; i++)
            {
                string cardRank = dealer.Hand.DisplayCards()[i].Rank;
                string cardSuit = dealer.Hand.DisplayCards()[i].Suit;
                Console.WriteLine($"  - {cardRank} of {cardSuit}");
            }
            Console.WriteLine($"Total: {dealerTotal}\n");
        }

        public void Hit()
        {
            Card playerCard = player.DrawCardFromDeck(deck);

            Console.WriteLine($"\nYou drew: {playerCard.Rank} of {playerCard.Suit}\n");
            Console.WriteLine($"Your current total is: {player.Hand.TotalCardValue()}");
        }

        public void Stand()
        {
            Card dealerHiddenCard = dealer.Hand.GetDealerHiddenCard();

            Console.WriteLine($"\nDealer's hidden card was: {dealerHiddenCard.Rank} of {dealerHiddenCard.Suit}\n");
            Console.WriteLine($"Dealer's current total: {dealer.Hand.TotalCardValue()}\n");

            // Dealer keeps hitting when total is 16 or less, and stops at 17 or more. A soft 17 also stops.
            while (dealer.Hand.TotalCardValue() < 17)
            {
                Card dealerCard = dealer.DrawCardFromDeck(deck);
                Console.WriteLine($"Dealer drew: {dealerCard.Rank} of {dealerCard.Suit}");
            }

            Console.WriteLine($"Dealer final total: {dealer.Hand.TotalCardValue()}");
        }
    }
}
