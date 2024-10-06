using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();


        
        

        int choice = -1;

        while (choice != 5)
        {
            Console.WriteLine("1. Write an Entry");
            Console.WriteLine("2. display Journal");
            Console.WriteLine("3. Save");
            Console.WriteLine("4.Load");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());


            if (choice == 1 )
            {
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                Entry newEntry = new Entry(_date, _promptText, _entryText);
                journal.AddEntry(newEntry);
            }

            else if (choice == 2 )
            {
                journal.DisplayAll();
            }

             else if (choice == 3 )
            {
                Console.WriteLine("Saving to the file...");
                journal.SaveToFile();
                

            }

            else if (choice == 4 )
            {
                journal.LoadFromFile();
            }

            else if (choice == 5)
            {
                break;
            }

            else
            {
                Console.WriteLine("Let's give it another try");
            }


            
        } 
            

    }
}