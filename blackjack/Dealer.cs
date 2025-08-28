namespace blackjack
{
    internal class Dealer
    {
        public Hand Hand { get; }

        public Dealer()
        {
            Hand = new Hand();
        }

        public Card DrawCardFromDeck(Deck deck)
        {
            Card drawnCard = deck.DrawCard();
            Hand.AddToHand(drawnCard);
            return drawnCard;
        }
    }
}
