using System;

// Creativity Features:
// - Added mood tracking for each journal entry
// - Added colored menu
// - Added total journal entry counter
// - Automatically displays entries after loading

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.ResetColor();

            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            // WRITE ENTRY
            if (choice == "1")
            {
                string prompt = prompts.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);

                Console.WriteLine("Entry added.");
            }

            // DISPLAY
            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            // SAVE
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved.");
            }

            // LOAD
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }

            // QUIT
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }

            // INVALID OPTION
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}