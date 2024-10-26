class Activity
{
    private string _name;
    private string _description;
    protected int _duration;



    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
    public void StartActivity()
    {
        Console.WriteLine($"Starting: {_name}");
        Console.WriteLine($"{_description}");


        if (_duration <= 0 )
        {
            Console.WriteLine("In seconds, How long would you like to do this activity ");
            _duration = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Get ready...");
        SpinnerAnimation(5);


    }

    protected void SpinnerAnimation(int seconds)
    {
        for (int i = 0; i < seconds *4; i++)
        {
            Console.WriteLine("|");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("\b/");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("\b -");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("\b\\");
            System.Threading.Thread.Sleep(250);
        }
    }


    public void EndMessage()
    {
         Console.WriteLine($"Good job! You've completed the {_name} activity for {_duration} seconds.");
         SpinnerAnimation(3);
    }

    




}