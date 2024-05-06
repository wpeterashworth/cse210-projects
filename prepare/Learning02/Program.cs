using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2022;
        job1._endYear = 2026;

        job2._company = "Google";
        job2._jobTitle = "Web Developer";
        job2._startYear = 2024;
        job2._endYear = 2030;

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResumeDetails();
    }
}