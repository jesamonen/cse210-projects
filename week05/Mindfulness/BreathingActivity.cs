using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "Relax by breathing slowly.";
    }

    public void Run()
    {
        StartActivity();

        for (int i = 0; i < _duration / 4; i++)
        {
            Console.WriteLine("\nBreathe In...");
            Thread.Sleep(2000);

            Console.WriteLine("Breathe Out...");
            Thread.Sleep(2000);
        }

        EndActivity();
    }
}