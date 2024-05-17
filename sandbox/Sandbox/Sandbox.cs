using System;

class Program
{
    static void Main(string[] args)
    {
        Person Fred = new Person("Fred", "Flinstone");
        Person Steve = new Person("Steve", "Jobs");


        Fred.EasternStyleName();
        Steve.WesternStyleName();
    }
}