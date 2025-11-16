using System;
using System.Collections.Generic;

namespace GuessTheWordGame
{
    public static class WordBank
    {
        // create a list of football players
        private static List<string> footballPlayers = new List<string>()
        {
            // Football players
            "ronaldo",
            "messi",
            "neymar",
            "mbappe",
            "ibrahimovic",
            "salah",
            "modric",
            "iniesta",
            "pele",
            "maradona",
            "zidane",
            "beckenbauer",
            "cruyff",
            "platini",
            "eusebio",
            "baggio",
            "totti",
            "kroos",
            "rooney",
            "pirlo",
            "henry",
            "rivaldo",
            "ronaldinho",
            "quaresma",
            "deco",
            "raul",
            "aimar",
            "joaquin",
            "gerrard",
            "balotelli",
            "berbatov",
            "cassano",
            "verratti",
            "pogba",
            "cannavaro",
            "riquelme",
            "beckham",
            "shevchenko",
            "inzaghi",
            "figo",
            "gattuso",
            "seedorf",
            "drogba",
            "lampard",
            "scholes",
        };

        // Returns a random word from the word list
        public static string GetRandomWord()
        {
            Random random = new Random();
            return footballPlayers[random.Next(footballPlayers.Count)];
        }

        // Returns total word count
        public static int GetWordCount()
        {
            return footballPlayers.Count;
        }
    }
}
