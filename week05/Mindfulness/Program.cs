using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");

        Console.Write("Choose: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            BreathingActivity activity = new BreathingActivity();
            activity.Run();
        }
        else if (choice == "2")
        {
            ReflectingActivity activity = new ReflectingActivity();
            activity.Run();
        }
        else if (choice == "3")
        {
            ListingActivity activity = new ListingActivity();
            activity.Run();
        }
    }
}