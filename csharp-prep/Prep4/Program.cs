using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        do
        {
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);
            numbers.Add(number);
        }
        while (number != 0);
        int sum = 0; 
        int greatestNumber = -1;
        foreach (int item in numbers)
        {
            sum += item;
            if (item > greatestNumber)
            {
                greatestNumber = item;
            }
        }
        int numberCount = numbers.Count;
        float average = ((float)sum) / numberCount; 
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The greatest number is: {greatestNumber}");
        }
}