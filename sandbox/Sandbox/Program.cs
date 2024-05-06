using System;

class Program
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    static void Main(string[] args)
    {
        Person person1 = new Person();
        // In the Main method or another part of the code
        // Creating an instance of the Person class
        person1.Name = "Peter";
        person1.Age = 22;
        // Accessing and setting properties of the instance
        person1.PrintDetails();
        // Calling a method on the instance
    }
}