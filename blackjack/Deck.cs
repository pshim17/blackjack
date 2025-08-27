using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            //string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] ranks = { "2", "3", "A" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    int value;

                    if (rank == "J" || rank == "Q" || rank == "K")
                    {
                        value = 10;
                    }
                    else if (rank == "A")
                    {
                        value = 11;
                    }
                    else
                    {
                        value = int.Parse(rank);
                    }
                    cards.Add(new Card(suit, rank, value));
                }
            }
            Shuffle();
        }

        public void Shuffle()
        {
            //Fisher-Yates shuffling algorithm
            Random random = new Random();

            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(i, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DrawCard()
        {
            Card card = cards[0];
            cards.Remove(card);
            return card;
        }
    }
}