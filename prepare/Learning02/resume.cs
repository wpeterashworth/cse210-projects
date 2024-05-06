using System;

public class Resume
{
    public string _name = "Peter Ashworth";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"\nName: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
        Console.WriteLine();
    }
}