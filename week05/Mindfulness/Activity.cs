using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);

        Console.Write("\nHow many seconds? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get Ready...");
        Thread.Sleep(2000);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGood Job!");
        Console.WriteLine($"You completed {_duration} seconds of {_name}");
        Thread.Sleep(2000);
    }
}