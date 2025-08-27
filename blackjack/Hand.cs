using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Hand
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddToHand(Card card)
        {
            cards.Add(card);
        }

        public List<Card> DisplayCards()
        {
            return cards;
        }

        public int TotalCardValue()
        {
            int total = 0;
            int aceCount = 0;

            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Rank == "A")
                {
                    aceCount++;
                } else
                {
                    total += cards[i].Value;
                }
            }
            
            for (int i =0; i < aceCount; i++)
            {
                if (total + 11 <= 21)
                {
                    total += 11;
                } else
                {
                    total += 1;
                }
            }
            return total;
        }

        public Card GetDealerHiddenCard()
        {
            return cards[0];
        }
    }
}
