using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        string letter = "";
        string sign = "";
        int grade = int.Parse(gradeString);
        Console.WriteLine();
        if (grade >= 93)
        {
            letter = "A";
            sign = "";
        }
        if (grade >= 90)
        {
            letter = "A";
            sign = "-";
        }
        else if (grade >= 87)
        {
            letter = "B";
            sign = "+";
        }
        else if (grade >= 83)
        {
            letter = "B";
            sign = "";
        }
        else if (grade >= 80)
        {
            letter = "B";
            sign = "-";
        }
        else if (grade >= 77)
        {
            letter = "C";
            sign = "+";
        }
        else if (grade >= 73)
        {
            letter = "C";
            sign = "";
        }
        else if (grade >= 70)
        {
            letter = "C";
            sign = "-";
        }
        else if (grade >= 67)
        {
            letter = "D";
            sign = "+";
        }
        else if (grade >= 63)
        {
            letter = "D";
            sign = "";
        }
        else if (grade >= 60)
        {
            letter = "D";
            sign = "-";
        }
        else
        {
            letter = "F";
        }
        List<string> lettersWithA = ["B", "C", "D"];
        if (lettersWithA.Contains(letter))
        {
            Console.Write($"You received a {letter}{sign} letter grade. ");
        }
        else
        {
            Console.Write($"You received an {letter}{sign} letter grade. ");
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("Sorry but you did not pass. ");
        }
    }
}