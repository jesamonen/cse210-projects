using System;
using System.Threading;

public class ReflectingActivity : Activity
{
    private string[] prompts =
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult."
    };

    public ReflectingActivity()
    {
        _name = "Reflection Activity";
        _description = "Reflect on positive experiences.";
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();

        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Thread.Sleep(_duration * 1000);

        EndActivity();
    }
}