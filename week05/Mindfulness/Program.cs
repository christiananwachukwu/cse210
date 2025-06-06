using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (input == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (input == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (input == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter and try again.");
                Console.ReadLine();
            }
        }
    }
}