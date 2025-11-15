using GuessTheWordGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Handles the word guessing game logic
// AI-inspired: Structure and shuffle method suggested by AI, adapted for Swedish words
public class WordGame
{
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
    }

    // Scrambles the letters in a word using Fisher-Yates shuffle
    // AI-inspired: Fisher-Yates shuffle algorithm suggested by AI
    private string ScrambleWord(string word)
    {
        char[] letters = word.ToCharArray();
        Random random = new Random();

        // Fisher-Yates shuffle algorithm
        for (int i = letters.Length - 1; i > 0; i--) // "AI valde att göra såhär, jag hade gjort såhär....blablba"
        {
            int j = random.Next(i + 1);
            // Swap letters[i] and letters[j]
            char temp = letters[i];
            letters[i] = letters[j];
            letters[j] = temp;
        }

        return new string(letters);
    }

    // Returns the scrambled word to display to player
    public string GetScrambledWord()
    {
        return scrambledWord;
    }

    // Checks if the player's guess matches the original word
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

    // Returns the original word (used when player loses)
    public string GetOriginalWord()
    {
        return originalWord;
    }
}