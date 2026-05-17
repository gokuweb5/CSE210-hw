using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;

    // list that stores objects of job type
    public List<Job> _jobs = new List<Job>();

    //Method to show the complete Resume

    public void Display()

    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop to iterate through the list and call the Display for each job
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}