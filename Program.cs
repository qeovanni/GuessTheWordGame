namespace GuessTheWordGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordGame game = new WordGame();
            game.StartNewGame();

            while (!game.IsGameOver())
            {
                Console.WriteLine("Guess the word: " + game.GetScrambledWord());
                string guess = Console.ReadLine();

                if (game.CheckGuess(guess))
                {
                    Console.WriteLine("Correct! The word was: " + game.GetOriginalWord());
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect! Attempts left: " + game.GetAttemptsLeft());
                }
            }

            if (game.IsGameOver())
            {
                Console.WriteLine("Game over! The word was: " + game.GetOriginalWord());
            }
        }
    }
}
