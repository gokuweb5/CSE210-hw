using System;

class Program
{
    static void Main(string[] args)
    {
        // generate the random number from 1 to 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Initialize the variable for the guess in 0
        int guess = 0;

        // keep the loop active while the user don't guess
        while (guess != magicNumber)
        {
            // Ask the try
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            // Validate if the number is greater than, less than, ot equal to
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}