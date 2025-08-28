# Blackjack

Welcome to Blackjack, a minimum viable product (MVP) C# console app implementing the core rules of casino blackjack. It is clean, clear, and ready to demo

## Implemented Rules:
- Deal a standard 52-card deck, with the dealer’s first card hidden
- Let you **hit** or **stand** with simple, clear console prompts
- Handle **Aces** intelligently (11 unless it would bust, then 1)
- Play the dealer correctly: **hits on 16 or less, stands on any 17 (including soft 17)**
- Show a clean **round summary**: both hands and totals, plus the result (Blackjack, Bust, Win/Loss, Push(Tie))

## Prerequisites
### Software and Tools Required
1. **.NET SDK**  
   - Version: **.NET 8+**  
   - Check:  
     ```sh
     dotnet --version
     ```
2. **Terminal**

## How to Run
From the project folder:
```sh
dotnet run
```

## How to Play
- Press any key to start the game
- Press 'h' to hit
- Press 's' to stand
- After a round:
  - Press 'y' to play again
  - Press 'n' to quit

## Design
- **Shuffle:** Fisher–Yates on a 52-card list at game start.
- **Ace algorithm:** sum non-aces first; add each Ace as 11 if it doesn’t bust, otherwise 1.
- **Dealer logic:** loop card draws while total `< 17`, so soft 17 stands by design.
- **I/O:** simple re-prompt on invalid input to keep it beginner-friendly.

## Project File Structure
- `Program.cs` — starts the app and runs the play-again loop
- `Game.cs` — runs one round: deal cards, read input, play dealer, decide winner, show summary
- `Deck.cs` — builds the deck, shuffles it, and deals cards
- `Card.cs` — represents one card (suit, rank, value)
- `Hand.cs` — stores a player’s cards and calculates the total (Ace = 11 or 1)
- `Player.cs` / `Dealer.cs` — simple classes that each have a Hand and draw from the Deck
 
## Limitations:
- No betting;
- No splitting
- No multiplayer

## Repository
- **Repository**: https://github.com/pshim17/blackjack
