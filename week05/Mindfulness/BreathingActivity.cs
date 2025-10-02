using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);

            Console.WriteLine();

            Console.Write("Now breathe out... ");
            ShowCountdown(6);

            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}
