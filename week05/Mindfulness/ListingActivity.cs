using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many kinds things people have done for you.",
        "List as many personal strengths you can think of.",
        "List as many blessings you’ve received this week."
    };

    public ListingActivity() : base("Listing Activity", "This will help you think positively by listing good things.") { }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.Write("You may begin in: ");
        ShowCountdown(5); // 🟡 Creativity: suspense countdown before start

        Console.WriteLine("\nStart typing now:");

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        DisplayEndingMessage();
    }
}