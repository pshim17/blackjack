using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Player
    {
        public Hand hand { get; }

        public Player()
        {
            hand = new Hand();
        }

        public Card DrawCardFromDeck(Deck deck)
        {
            Card drawnCard = deck.DrawCard();
            hand.AddtoHand(drawnCard);
            return drawnCard;
        }
    }
}
