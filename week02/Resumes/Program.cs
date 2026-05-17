using System;

class Program
{
    static void Main(string[] args)
    {
       // WE initiated the first job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // We instantiated the second job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // We instantiated the main resume with my name
        Resume myResume = new Resume();
        myResume._name = "Luis Hernandez";

        // We add the two Job objects to the Resume list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // We display the entire result on the console
        myResume.Display();
    }
}