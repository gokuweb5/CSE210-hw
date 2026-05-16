using System;

class Program
{
    static void Main(string[] args)
    {
        // call the functions in the exact order
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squaredNumber = SquareNumber(number);

        DisplayResult(name, squaredNumber);
    }
    // show the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    // Ask the user name and return as a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // ask the favorite user number and return it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // gets an integer, calculates the square and return it
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }

}