using System;

namespace GuessTheWordGame
{
    // Handles the word guessing game logic
    // AI-inspired: Structure and shuffle method suggested by AI

    public class WordGame
    {
        Random random = new Random();
        private string originalWord;
        private string scrambledWord;
        private int attemptsLeft;
        private int maxAttempts;

        // Constructor initializes game with specified number of attempts
        public WordGame(int maxAttempts = 3)
        {
            this.maxAttempts = maxAttempts;
            this.attemptsLeft = maxAttempts;
        }

        // Starts a new game with a random word from WordBank
        public void StartNewGame()
        {
            originalWord = WordBank.GetRandomWord();
            scrambledWord = ScrambleWord(originalWord);
            attemptsLeft = maxAttempts; // Reset attempts for new game
        }

        // AI-inspired: Fisher-Yates shuffle algorithm suggested by AI to scramble the word. 
        private string ScrambleWord(string word)
        {
            char[] letters = word.ToCharArray();

            // AI suggested counting backwards, personally I would have started from 0.
            // Found out that counting backwards is industrial standard for this algorithm, so I kept it.
            for (int i = letters.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                // Swap letters[i] and letters[j]
                char temp = letters[i];
                letters[i] = letters[j];
                letters[j] = temp;
            }
            return new string(letters);
        }

        // Returns the scrambled word to display to user
        public string GetScrambledWord()
        {
            return scrambledWord;
        }

        // Checks if the user's guess matches the original word
        // Returns true if correct, false otherwise
        public bool CheckGuess(string guess)
        {
            attemptsLeft--;
            return guess.ToLower().Trim() == originalWord.ToLower();
        }

        // Returns the number of attempts remaining
        public int GetAttemptsLeft()
        {
            return attemptsLeft;
        }

        // Returns true if game is over (no attempts left)
        public bool IsGameOver()
        {
            return attemptsLeft <= 0;
        }

        // Returns the original word (used when user loses)
        public string GetOriginalWord()
        {
            return originalWord;
        }
    }
}