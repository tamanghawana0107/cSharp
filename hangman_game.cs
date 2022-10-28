//hangman game
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cSharp
{
    class hangman_game
    {
        static void Main(string[] args)
        {
            bool a = true;
            Console.WriteLine("***Welcome to Hangman Game***");
            string[] listword = new string[10];
            listword[0] = "sheep";
            listword[1] = "goat";
            listword[2] = "computer";
            listword[3] = "america";
            listword[4] = "watermelon";
            listword[5] = "icecream";
            listword[6] = "jasmine";
            listword[7] = "pineapple";
            listword[8] = "orange";
            listword[9] = "mango";
            Random randGen = new Random();
            var idx = randGen.Next(0,10);
            string mysteryWord = listword[idx];
            char[] guess  = new char[mysteryWord.Length];
            Console.WriteLine("Please enter your guess word  length:");
            for(int p = 0; p< mysteryWord.Length;p++)
            {
                guess[p] = '*';
            }
            while(a)
            {

                char playerGuess = char.Parse(Console.ReadLine());
                for(int j = 0 ;j<mysteryWord.Length;j++)
                {
                    if(playerGuess == mysteryWord[j])
                    {
                        guess[j] = playerGuess;
                    }
                }
                Console.WriteLine(guess);
                if(new string(guess)== mysteryWord)
                {
                    a = false;
                }
            }
            Console.WriteLine("!!!You got the word correct!!!");
            Console.Read();
        }
    }
}