using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // EXCEEDING REQUIREMENT: Randomly selects a scripture each time the program runs
        ScriptureGenerator scriptureGen = new ScriptureGenerator();
        Scripture scripture = scriptureGen.GetRandomScripture();

        while (true)
        {
            Console.Clear();

            // Displays the scripture with hidden words
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture.AllWordsHidden())
            {
                break;
            }

            scripture.HideRandomWords(3); // Hides 3 random words each round
        }

        Console.WriteLine("\nProgram ended.");
    }
}