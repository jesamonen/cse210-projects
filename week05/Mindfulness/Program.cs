using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            Console.Write("\nChoose: ");
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
            else if (choice == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadKey();
                continue;
            }

            if (running)
            {
                Console.Write("\nDo another activity? (y/n): ");
                string answer = Console.ReadLine().ToLower();

                if (answer != "y")
                {
                    running = false;
                }
            }
        }

        Console.WriteLine("\nThank you for using the Mindfulness Program!");
    }
}