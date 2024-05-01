using System;
using System.Formats.Asn1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine();
            Console.Write("Would you like to play a game of magic number? ");
            string answer = Console.ReadLine().ToLower();
            while (answer == "yes" || answer == "yeah" || answer == "yep" || answer == "yup" || answer == "yea" || answer == "ya")
            {
                List<string> guesses = [];
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 50);
                Console.Write("What is the magic number? (Guess between numbers 1 and 50...) ");
                string userGuessString = Console.ReadLine();
                int userGuess = int.Parse(userGuessString);
                guesses.Add(userGuessString);
                if (userGuess == magicNumber)
                {
                    Console.WriteLine("Wow! First Try!");
                }
                else if (userGuess > magicNumber)
                {
                    while (userGuess > magicNumber)
                    {
                        Console.Write("Try a lower number. ");
                        userGuessString = Console.ReadLine();
                        guesses.Add(userGuessString);
                        userGuess = int.Parse(userGuessString);
                        continue;
                    }
                }
                else if (userGuess < magicNumber)
                {
                    while (userGuess < magicNumber)
                    {
                        Console.Write("Try a higher number. ");
                        userGuessString = Console.ReadLine();
                        guesses.Add(userGuessString);
                        userGuess = int.Parse(userGuessString);
                        continue;
                    }
                }
                int guessCount = guesses.Count;
                Console.Write("You guessed the magic number! Congrats! ");
                Console.WriteLine($"You made {guessCount} guesses in total.");
                Console.WriteLine();
                Console.Write("Would you like to play again? ");
                answer = Console.ReadLine().ToLower();
            }
        }
    }
}