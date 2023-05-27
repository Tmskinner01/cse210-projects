using System;

class Program
{
    static void Main(string[] args)
    {
        // set up variables and scripture.
        Reference reference1 = new Reference("1 Thessalonians", 5 , 26);
        string _scriptureReference = reference1.GetReference();
        string fullText = "Greet all the brethren with an holy kiss.";
        Scripture scripture1 = new Scripture(_scriptureReference, fullText);

        string input = "";
        do
        {
            //prints scripture
            Console.Clear();
            scripture1.GetRenderedText();
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish ");
            Console.WriteLine();
            input = Console.ReadLine();
            //randomly select words to hide
            scripture1.HideWords();
            scripture1.IsCompletelyHidden();
            bool completelyHidden = scripture1.GetHiddenBool();

            if(completelyHidden)
            {
                Console.Clear();
                scripture1.GetRenderedText();
                string textFromMemory = "";
                bool memorized = false;

                do 
                {
                    Console.WriteLine();
                    Console.WriteLine("Please type your verse below (case/punctuation sensitive): ");
                    Console.WriteLine();
                    textFromMemory = Console.ReadLine();
                    Console.WriteLine();
                    if (textFromMemory == fullText)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Excellent work! You were able to retype the verse from memory!");
                        memorized = true;
                        input = "quit";
                    }
                    else if(textFromMemory == "quit" )
                    {
                        memorized = true;
                        input = "quit";
                    }
                    else
                    {
                        Console.WriteLine("Not quite. Keep trying or type 'quit' to exit.");
                    }
                }
                while (memorized == false);

            }
        }
        while(input != "quit" );
    }
}