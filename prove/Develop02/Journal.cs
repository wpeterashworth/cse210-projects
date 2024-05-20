using System;
using System.IO;
// acquire necessary System directives

class Journal
// Journal class: responsible for writing, displaying, saving, and loading to and from a journal provided by the user.
{
    public List<string> _promptList = new List<string>();
    // Need a global empty list for the prompt generator
    public List<Entry> _entries = new List<Entry>();
    // Instantiate the Entry class into a new List

    public void MenuMethod()
    // Method that should probably be in program.cs, but is not. Creates essentially a menu for the user to pick which option they desire.
    // It returns nothing and receives no parameters
    {
        Console.WriteLine("Please enter your desired option: ");
        Console.Write(" 1.Write\n 2.Display\n 3.Load\n 4.Save\n 5.Quit\n > ");
        string _userInput = Console.ReadLine();
        // Giving user an option and receiving input
        if (_userInput == "1")
        // Using conditional statements to decide which method to pursue
        {
            Write();
            MenuMethod();
        }
        else if (_userInput == "2")
        {
            Display();
            MenuMethod();
        }
        else if (_userInput == "3")
        {
            Load();
            MenuMethod();
        }
        else if (_userInput == "4")
        {
            Save();
            MenuMethod();
        }
        else
        // if something other than the numbers 1-5 are selected, terminate the program
        {

        }
    }

    public void Write()
    // The write method does a few things, or tasks. 1. Retrieves the current date || 2. Calls the prompt generator method and selects a prompt || 
    // 3. Ask the user for an entry and retrieve input || 4. Instantiates the Entry class, and adds inputted entry into the Entry list from the Entry class, called "entries", that was created globally earlier...
    // It returns nothing and receives no parameters
    {
        MakePrompt();
        // part of task 2 ^^^^ (refer to comments for the write method)
        DateTime theCurrentTime = DateTime.Now;
        string _dateNow = theCurrentTime.ToShortDateString();
        // part of task 1  ^^^^
        Random _randomPrompt = new Random();
        int index = _randomPrompt.Next(_promptList.Count);
        string _randomlySelectedPrompt = _promptList[index];
        // task 2 ^^
        Console.WriteLine(_randomlySelectedPrompt);
        Console.Write("> ");
        string journalEntry = Console.ReadLine();
        // task 3 ^^
        Entry entry = new Entry(_dateNow, _randomlySelectedPrompt, journalEntry);
        _entries.Add(entry);
        // task 4 ^^
    }

    public void Display()
    // This method is merely calling the method for display inside of the Entry class
    {
        foreach (Entry entry in _entries)
        // an instance of Entry is made in a loop
        {
            entry.Display();
        }
    }

    public void Save()
    // same as Display method
    {
        foreach (Entry entry in _entries)
        {
            entry.Save();
        }
    }
    public void Load()
    // load the saved file (can be any file saved in the same section of the repo)
    {
        Console.WriteLine("What file would you like to load from? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        // Read the contents of file after asking user which one
        foreach (string line in lines)
        {
            Console.Write($"{line}\n");
            // write to the console the contents of the file
        }
        Console.WriteLine();
    }

    public void MakePrompt()
    // a prompt generator that adds to the _promptList
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
        _promptList.Add(prompt1);
        _promptList.Add(prompt2);
        _promptList.Add(prompt3);
        _promptList.Add(prompt4);
        _promptList.Add(prompt5);
        _promptList.Add(prompt6);
        _promptList.Add(prompt7);
        _promptList.Add(prompt8);
        _promptList.Add(prompt9);
        _promptList.Add(prompt10);
    }
}