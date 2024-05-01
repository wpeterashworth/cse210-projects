using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName, numberSquared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("\nWelcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userNumberString = Console.ReadLine();
        Console.WriteLine();
        int userNumber = int.Parse(userNumberString);
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        return userNumber * userNumber;
    }

    static void DisplayResult(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is: {numberSquared}\n");
    }
}