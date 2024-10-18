using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference and text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scriptures scripture = new Scriptures(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        // Show the scripture and keep hiding words until all are hidden
        while (!scripture.AllWordsHidden())
        {
            Console.Clear(); // Clear the console
            Console.WriteLine(scripture.GetScriptureText()); // Display scripture
            Console.WriteLine("\nPress enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideWords(); // Hide random words
        }

        Console.WriteLine("All words are hidden. Goodbye!");
    }
}
