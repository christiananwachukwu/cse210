// Enhancements added
// 1. Saved journal entries as CSV format
// 2. Tracked user mood for each journal entry

using System;
using System.Collections.Generic;

class Program
{
    static readonly Dictionary<int, string> moodOptions = new Dictionary<int, string>
    {
        {1, "Angry"},
        {2, "Sad"},
        {3, "Neutral"},
        {4, "Happy"},
        {5, "Excited"},
    };

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator genrator = new PromptGenerator();

        int choice;
        do
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            bool valid = int.TryParse(Console.ReadLine(), out choice);
            if (!valid)
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = genrator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Console.Write("How would you describe your mood today? ");
                    string mood = GetMoodFromUser();

                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    journal.AddEntry(new Entry(date, prompt, response, mood));
                    break;

                case 2:
                    Console.WriteLine("\nYour Journal Entries:");
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully.");
                    break;

                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully.");
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

        } while (choice != 5);
    }

    static string GetMoodFromUser()
    {
        Console.WriteLine("\nSelect your mood for today:");
        foreach (var moodOption in moodOptions)
        {
            Console.WriteLine($"{moodOption.Key}. {moodOption.Value}");
        }

        Console.Write("Enter the number (1-5) for your mood: ");
        int moodChoice;
        while (!int.TryParse(Console.ReadLine(), out moodChoice) || !moodOptions.ContainsKey(moodChoice))
        {
            Console.Write("Invalid input. Please enter a number between 1 and 5: ");
        }

        string mood = moodOptions[moodChoice];
        Console.WriteLine($"Your mood: {mood}");
        return mood;
    }
}