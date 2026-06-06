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

        Console.Write("\nGet Ready... ");
        ShowSpinner();
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGood Job!");
        Console.WriteLine($"You completed {_duration} seconds of {_name}");

        Console.Write("Finishing... ");
        ShowSpinner();
    }

    protected void ShowSpinner()
    {
        string[] spinner = { "|", "/", "-", "\\" };

        for (int i = 0; i < 12; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
        }

        Console.WriteLine();
    }
}