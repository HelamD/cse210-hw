class Reflection : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
    };

    public Reflection(int duration) :base("Reflection Activity", "This activity will help you reflect on times of strength and resilience.", 60)
    {

    }
    
    
    

    public void RunReflection()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        SpinnerAnimation(3);

        EndMessage();
    }
}
    

