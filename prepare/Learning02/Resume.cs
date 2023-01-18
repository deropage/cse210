using System;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {

    }
    public void Display()
    {
        Console.Write($"{_name}\nJobs:\n");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}