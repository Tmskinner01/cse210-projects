using System;

public class ListingActivity : Activity
{
    protected List<string> listingEntries = new List<string>();
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        //set prompts
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
    }
    public void AddListEntry()
    {
        Console.Write(">");
        string newEntry = Console.ReadLine();
        listingEntries.Add(newEntry);

    }
    public int FindListLength()
    {
        int listLength = listingEntries.Count();
        return listLength;
    }
}