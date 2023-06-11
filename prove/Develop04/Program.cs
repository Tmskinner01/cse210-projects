using System;

class Program
{
    static void Main(string[] args)
    {   
        string menuInput = "0";
        do
        {
           Console.WriteLine("Menu Options:");
           Console.WriteLine("  1. Start breathing activity");
           Console.WriteLine("  2. Start reflecting activity");
           Console.WriteLine("  3. Start listing activity");
           Console.WriteLine("  4. Start sensation activity");
           Console.WriteLine("  5. Quit");
           Console.Write("Select a choice from the menu: ");

           menuInput = Console.ReadLine();
           Console.Clear();

           if (menuInput == "1")
           {
                BreathingActivity breathing1 = new BreathingActivity();
                
                // execute breathing activity functions
                int duration = breathing1.DisplayStart();
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(duration);
                while (DateTime.Now < endTime)
                {
                    breathing1.BreatheIn();
                    breathing1.BreatheOut();
                }

                // end breathing activity
                
                breathing1.DisplayEnd();
           }
           else if (menuInput == "2")
           {
               // create new activity object and set variables
               ReflectingActivity reflecting1 = new ReflectingActivity();
               int duration = reflecting1.DisplayStart();
          
               //generate prompt and give user time to think, then begin the activity
               Console.WriteLine("Consider the following prompt:");
               Console.WriteLine();
               Console.WriteLine($"---{reflecting1.GeneratePrompt()}---");
               Console.WriteLine();
               Console.Write("When you have something in mind, press enter to continue.");
               string ready = Console.ReadLine();
               Console.WriteLine();
               Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
               Console.Write("You may begin in: ");
               reflecting1.PauseTimer(5);
               Console.Clear();

               // timer starts now
               DateTime startTime = DateTime.Now;
               DateTime endTime = startTime.AddSeconds(duration);
               while (DateTime.Now < endTime)
                {
                    Console.Write($">{reflecting1.GenerateQuestion()} ");
                    reflecting1.PauseSpinner(8);
                    Console.WriteLine();
                }
                
               //end activity
               reflecting1.DisplayEnd();

           }
           else if (menuInput == "3")
           {
               ListingActivity listing1 = new ListingActivity();
               int duration = listing1.DisplayStart();

               Console.WriteLine("List as many repsonses as you can to the following prompt: ");
               Console.WriteLine($"---{listing1.GeneratePrompt()}---");
               Console.Write("You may begin in: ");
               listing1.PauseTimer(5);
               Console.WriteLine();

                // timer starts now
               DateTime startTime = DateTime.Now;
               DateTime endTime = startTime.AddSeconds(duration);
               while (DateTime.Now < endTime)
               {
                    listing1.AddListEntry();
               }
                
                //print end message and calculate list length
                int listLength = listing1.FindListLength();
                Console.WriteLine($"You listed {listLength} items!");
                Console.WriteLine();
                listing1.DisplayEnd();
           }
           else if (menuInput == "4")
           {
                SensationActivity sensation1 = new SensationActivity();
                int duration = sensation1.DisplayStart();

               Console.Write($"Begin to notice a tingling sensation in your {sensation1.GeneratePrompt()}");
               sensation1.PauseSpinner(3);
               Console.WriteLine();
               Console.WriteLine();

               // timer starts now
               DateTime startTime = DateTime.Now;
               DateTime endTime = startTime.AddSeconds(duration);
               while (DateTime.Now < endTime)
               {
                    sensation1.MoveSensation();
               }

               sensation1.DisplayEnd();

           }
           else if (menuInput == "5")
           {
                Console.WriteLine("Goodbye!");
           }
           else
           {
                Console.WriteLine("Please enter a valid menu option.");
           }
            Console.Clear();
        }
        while (menuInput != "5");
    }
}