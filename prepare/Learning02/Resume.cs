using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.Write($"{_name}");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}
