namespace blackjack
{
    internal class Player
    {
        public Hand Hand { get; }

        public Player()
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
