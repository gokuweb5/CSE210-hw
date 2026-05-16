using System;

class Program
{
    static void Main(string[] args)
    {
        // ask the percentage to the user and convert it to an integer

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        // create the variable to save the letter

        string letter = "";

        // Determine the letter according to the scale

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the result of the letter once at the end
        Console.WriteLine($"Your grade is: {letter}");

        // verify if passed the subject
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Thanks for participating!");
        }
    }
}