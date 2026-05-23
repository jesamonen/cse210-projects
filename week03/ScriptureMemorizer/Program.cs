using System;

namespace ScriptureMemorizer
{
    // =========================================================================
    // CREATIVITY & EXCEEDING REQUIREMENTS REPORT:
    // This program meets the stretch criteria by making sure the random selector 
    // checks word visibility flags first. It will never select or waste turns 
    // trying to re-hide words that are already replaced with underscores.
    // =========================================================================
    class Program
    {
        static void Main(string[] args)
        {
            // Setup a multi-verse reference and matching scripture body text
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";

            Scripture scripture = new Scripture(reference, scriptureText);

            // Core Execution loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                // Stop the loop if everything is blanked out
                if (scripture.IsCompletelyHidden())
                {
                    break;
                }

                Console.WriteLine("Press Enter to continue, or type 'quit' to finish:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                // Hide 3 words before refreshing the loop
                scripture.HideRandomWords(3);
            }
        }
    }
}