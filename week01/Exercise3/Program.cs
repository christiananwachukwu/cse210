using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;
        Random randomGenerator = new Random();
        Console.WriteLine("Welcome to the number guessing game!");

        while (playAgain)
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess;
            int attempts = 0;

            Console.WriteLine("\nI'm thinking of a number between 1 and 100.");

            while (true)
            {
                Console.Write("What is your guess? ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    attempts++;
                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                    }
                    else if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in {attempts} attempts!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing!");
    }
}