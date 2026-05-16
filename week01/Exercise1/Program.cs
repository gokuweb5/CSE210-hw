using System;

class Program
{
    static void Main(string[] args)
    {
        // ask for the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // ask for the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // blanc line 
        Console.WriteLine();

        // Print result using sign $

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}

