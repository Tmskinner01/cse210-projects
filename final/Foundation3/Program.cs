using System;

class Program
{
    static void Main(string[] args)
    {
        //Event 1
        Address address1 = new Address("603 Old York Court", "Lake Charles", "LA", "70605");
        Lecture lecture1 = new Lecture("The Impact of Social Media on Body Image and Self-esteem", "Listen to Dr. Aleksandr Soto as he explores the negative effects social media is having on our mental health.", "July 26th 2023", "10:00 AM", address1, "50", "Dr. Aleksandr Soto");

        lecture1.GetFullDetatails();
        Console.WriteLine();
        lecture1.GetShortDescription();
        Console.WriteLine();
        lecture1.GetStandardDetails();
        Console.WriteLine();

        //Event 2 
        Address address2 = new Address("630 Jefferson St","Loganville", "GA", "30052");
        Reception reception1 = new Reception("The Smiths' Wedding Reception","Join the Smiths as they celebrate a new chapter in their life.", "August 20th 2023", "6:00 PM", address2, "perfectplanningeventcoordinators@gmail.com");
        
        reception1.GetFullDetatails();
        Console.WriteLine();
        reception1.GetShortDescription();
        Console.WriteLine();
        reception1.GetStandardDetails();
        Console.WriteLine();

        //Event 3 
        Address address3 = new Address("4670 Warren Lane", "Sandusky", "OH", "48706");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Zimmer Biomet Company Picnic", "Join Zimmer in celebrating it's employees with a day of fun at Cedar Point.", "August 5, 2023","10:00 AM", address3, "Sunny, with a high of 85 degrees.");

        outdoorGathering1.GetFullDetatails();
        Console.WriteLine();
        outdoorGathering1.GetShortDescription();
        Console.WriteLine();
        outdoorGathering1.GetStandardDetails();
        Console.WriteLine();

    }
}