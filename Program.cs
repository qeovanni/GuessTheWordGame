using System;

namespace GuessTheWordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new game with 3 attempts
            WordGame game = new WordGame(3);

            bool playAgain = true;

            while (playAgain)
            {
                // Start a new round
                game.StartNewGame();

                Console.Clear();
                // AI generated welcome banner.
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║  Welcome to Guess the Football Player!   ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.WriteLine("\nWhat player are we seeking?");
                Console.WriteLine($"Scrambled player name: {game.GetScrambledWord()}");
                Console.WriteLine($"You have {game.GetAttemptsLeft()} attempts to guess the right football player.\n");

                // Game loop
                while (!game.IsGameOver())
                {
                    Console.Write($"Attempts left: {game.GetAttemptsLeft()} | Your guess: ");
                    string guess = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(guess))
                    {
                        Console.WriteLine("You must write something!\n");
                        continue;
                    }

                    if (game.CheckGuess(guess))
                    {
                        Console.WriteLine("\nCorrect! You won!\n");
                        break;
                    }
                    else
                    {
                        if (!game.IsGameOver())
                        {
                            Console.WriteLine("Wrong guess! Try again.\n");
                        }
                    }
                }

                // Game over - show result
                if (game.IsGameOver())
                {
                    Console.WriteLine($"\nGame Over! The correct football player was: {game.GetOriginalWord()}\n");
                }

                // Ask if user wants to play again
                Console.Write("Do you want to play again? (y/n): ");
                string response = Console.ReadLine().ToLower();
                playAgain = response == "y" || response == "yes";
            }

            Console.WriteLine("\nThanks for playing! Goodbye!");
        }
    }
}