using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 . Breathing activity");
        Console.WriteLine("2 . Reflecting activity");
        Console.WriteLine("3 . Listing activity");
        Console.WriteLine("4 . Quit");
        Console.Write("Enter a number to star an activity: ");
        string answer = Console.ReadLine();
        
        while (true)
        {
            if (answer ==  "1")
            {
                Console.WriteLine("Starting Breathing Activity...");
                Breathing breath = new Breathing(0);

                breath.RunBreathing();
            }

            else if (answer ==  "2")
            {
               Console.WriteLine("Starting reflecting Activity...");
               Reflection reflect = new Reflection(0);
               reflect.RunReflection();
            }

            else if (answer ==  "3")
            {
                Console.WriteLine("Starting listing Activity...");
                Listing listed = new Listing(0);
                listed.RunListing();
            }

            else if (answer ==  "4")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Opss, better select a correct option from the menu to start the activity");
                System.Threading.Thread.Sleep(1000);
            }
        }

    }
}