using System;

public class Job
{
    // atributes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Method to show the data of this job

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}--{_endYear}");
    }
}