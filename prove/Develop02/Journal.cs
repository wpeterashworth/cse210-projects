using System;
using System.IO;
using System.Collections.Generic;

class Journal
{
    public List<string> promptList = new List<string>();
    public List<Entry> entries = new List<Entry>();

    public void MenuMethod()
    {
        Console.WriteLine("Please enter your desired option: ");
        Console.Write(" 1.Write\n 2.Display\n 3.Load\n 4.Save\n 5.Quit\n > ");
        string userInput = Console.ReadLine();
        if (userInput == "1")
        {
            Write();
            MenuMethod();
        }
        else if (userInput == "2")
        {
            Display();
            MenuMethod();
        }
        else if (userInput == "3")
        {
            Load();
            MenuMethod();
        }
        else if (userInput == "4")
        {
            Save();
            MenuMethod();
        }
        else
        {

        }
    }

    public (string, string, string) Write()
    {
        MakePrompt();
        DateTime theCurrentTime = DateTime.Now;
        string dateNow = theCurrentTime.ToShortDateString();
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(promptList.Count);
        string randomlySelectedPrompt = promptList[index];
        Console.WriteLine(randomlySelectedPrompt);
        Console.Write("> ");
        string journalEntry = Console.ReadLine();
        Entry entry = new Entry(dateNow, randomlySelectedPrompt, journalEntry);
        entries.Add(entry);
        return (dateNow, randomlySelectedPrompt, journalEntry);
    }

    public void Display()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void Save()
    {
        foreach (Entry entry in entries)
        {
            entry.Save();
        }
    }
    public void Load()
    {
        Console.WriteLine("What file would you like to load from? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.Write($"{line}\n");
        }
    }

    public void MakePrompt()
    {
        string prompt1 = ("If I had one thing I could do over today, what would it be? ");
        string prompt2 = ("How have I seen the hand of the Lord in my life today? ");
        string prompt3 = ("What was the best part of my day? ");
        string prompt4 = ("What am I grateful for? ");
        string prompt5 = ("Who am I grateful for? ");
        string prompt6 = ("What, during the day, has reminded me of what is most important in life? ");
        string prompt7 = ("What is something someone has said recently that inspired me to do better? ");
        string prompt8 = ("What have I learned today?");
        string prompt9 = ("What places have I visited recently that helped me feel peace? ");
        string prompt10 = ("What is something that I read recently that gave me hope and comfort? ");
        promptList.Add(prompt1);
        promptList.Add(prompt2);
        promptList.Add(prompt3);
        promptList.Add(prompt4);
        promptList.Add(prompt5);
        promptList.Add(prompt6);
        promptList.Add(prompt7);
        promptList.Add(prompt8);
        promptList.Add(prompt9);
        promptList.Add(prompt10);
    }
}