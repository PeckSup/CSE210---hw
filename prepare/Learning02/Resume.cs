using System;

public class Resume
{
    public string _name = "";
    // The resume will likely have multiple jobs
    // So we make a list for them
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }


    }
    
}