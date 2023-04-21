using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);
        string letter = "F";
        
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Letter Grade: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Keep Studying, You'll get there!");
        }


    }
}