using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "List good things in your life.";
    }

    public void Run()
    {
        StartActivity();

        List<string> items = new List<string>();

        Console.WriteLine("Enter items (press Enter to stop):");

        string item = "";

        while (item != "done")
        {
            item = Console.ReadLine();

            if (item != "done")
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");

        EndActivity();
    }
}