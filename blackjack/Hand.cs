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
        int total;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddtoHand(Card card)
        {
            cards.Add(card);
        }

        public List<Card> DisplayCards()
        {
            return cards;
        }

        public int TotalCardValue()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                total += cards[i].Value;
            }
            return total;
        }
    }
}
