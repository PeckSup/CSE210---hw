using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // First Job Information
        Job job1 = new Job();
        job1._company = "Finland";
        job1._position = "Blacksmith";
        job1._startYear = 1407;
        job1._endYear = 1418;

        //Second job information
        Job job2 = new Job();
        job2._company = "Wendy's";
        job2._position = "Manager";
        job2._startYear = 2007;
        job2._endYear = 2020;

        //Assemble resume
        Resume resume1 = new Resume();
        resume1._name = "Jeff Ubetcha";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        //Display resume
        resume1.DisplayResume();
        
    }
}