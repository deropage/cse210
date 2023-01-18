using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume1 = new Resume();
        resume1._name = "David Segura";
        Job job1 = new Job();
        Job job2 = new Job();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs[0]._company = "Microsoft";
        resume1._jobs[0]._jobTitle = "Software Engineer";
        resume1._jobs[0]._startYear = 2010;
        resume1._jobs[0]._endYear = 2015;
        resume1._jobs[1]._company = "Apple";
        resume1._jobs[1]._jobTitle = "Software Developer";
        resume1._jobs[1]._startYear = 2015;
        resume1._jobs[1]._endYear = 2022;

        resume1.Display();
    }
}