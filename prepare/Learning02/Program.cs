using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2019;
        
        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Games Workshop";
        job2._startYear = 2019;
        job2._endYear = 2023;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume.Display();
    }

}