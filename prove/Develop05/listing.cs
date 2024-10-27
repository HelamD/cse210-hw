class Listing : Activity
{
    private List<string> _prompts= new List<string>
    {
        "List people who have influenced you.",
        "List your personal strengths.",
        "List things that make you happy."
    };

    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in life by listing them.", 60)
    {

    }

    public void RunListing()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        Console.WriteLine("Star listinhg items");
        SpinnerAnimation();

        Console.WriteLine("Type your items (press Enter after each, type 'done' to finish):");

        int count = 0;
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
            break;
            count++;
        }

        Console.WriteLine($"you listed {count} intems");

        EndMessage();


    }
}