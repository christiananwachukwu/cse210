using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This will help you relax by guiding you through deep breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int cycleTime = 6; // 3s inhale, 3s exhale

        while (duration > 0)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(3); // Simple countdown
            Console.Write("Now breathe out... ");
            ShowCountdown(3);

            duration -= cycleTime;
        }

        DisplayEndingMessage();
    }
}