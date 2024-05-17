using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal.MenuMethod();
        // make an instance of the journal class and then call the method inside of that class that does all the abstraction
    }
}

// I worked on this assignment for many hours and therefore know that there are faults, including pieces that are in the entry class that do not belong there,
// as well as the program asking which file the user wants to save to for each entry. I attempted to exceed requirements in a couple of ways but none were really successful, 
// although I did provide a way for the program to tell if an entry had already been saved and then to not save it if that exact entry had already been saved.
