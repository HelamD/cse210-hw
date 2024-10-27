using System.Data;

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
        SpinnerAnimation();


    }

    protected void SpinnerAnimation()
    {      
        List<string> animationString = new List<string>();
        {
            animationString.Add("|");
            animationString.Add("/");
            animationString.Add("-");
            animationString.Add("\\");
            animationString.Add("|");
            animationString.Add("-");
        }


        foreach (string animation in animationString )
        {
            
            Console.Write(animation);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(".");
            Thread.Sleep(1000);

            i++;

            if (i > animationString.Count)
            {
                i = 0;
            }
        }
    }    

    public void EndMessage()
    {
        Console.WriteLine($"Good job! You've completed the {_name} activity for {_duration} seconds.");
         SpinnerAnimation();
        
    }
}



    




