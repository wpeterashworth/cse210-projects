using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nPlease provide a series of numbers. Type 0 when finished");
        List<int> numbersList = new List<int>();
        while (!numbersList.Contains(0))
        {
            Console.Write("What number? ");
            int number = int.Parse(Console.ReadLine());
            numbersList.Add(number);
        }
        numbersList.Remove(0);
        int sumTotal = numbersList.Sum();
        double average = sumTotal / numbersList.Count;
        int largestNumber = numbersList.Max();
        Console.WriteLine($"\nThe sum is: {sumTotal}\nThe average is: {average}\nThe largest number is: {largestNumber}");
        numbersList.Sort();
        Console.WriteLine("\nSorted numbers:");
        for (int i = 0; i < numbersList.Count; i++)
        {
            int number = numbersList[i];
            Console.WriteLine(number);
        }
    }
}