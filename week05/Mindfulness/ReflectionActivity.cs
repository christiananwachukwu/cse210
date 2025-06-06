using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you did something really brave.",
        "Think of a time you helped someone in need.",
        "Think of a moment you felt really proud of yourself."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn from it?",
        "Would you do anything differently next time?",
        "How did this make you stronger?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This will help you reflect on times when you were strong.") { }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.WriteLine("Now reflect on the questions that follow...");
        ShowSpinner(3); // 🟡 Creativity: short pause before questions

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.Write($"> {question} ");
            ShowSpinner(5); // 🟡 Creativity: gives user thinking time
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}