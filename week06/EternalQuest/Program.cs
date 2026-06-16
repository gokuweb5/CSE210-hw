using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}