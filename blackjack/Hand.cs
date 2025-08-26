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

            for (int i = 0; i < cards.Count; i++)
            {
                total += cards[i].Value;
            }
            return total;
        }

        public Card GetDealerHiddenCard()
        {
            return cards[0];
        }
    }
}
