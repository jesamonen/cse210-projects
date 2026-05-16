using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            // DISPLAY MENU
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write( "Type a number to select choice:");

            choice = Console.ReadLine();

            // WRITE ENTRY
            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);
            }

            // DISPLAY ENTRIES
            else if (choice == "2")
            {
                Console.WriteLine();
                journal.DisplayAll();
            }

            // SAVE FILE
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully.");
            }

            // LOAD FILE
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
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
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}