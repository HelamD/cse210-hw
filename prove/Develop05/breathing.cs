class Breathing : Activity
{
    
    public Breathing(int duration): base("Breathing Activity", "This activity will help you relax by guiding your breathing",duration)
    {

    }

    public void RunBreathing()
    {
        StartActivity();

        for (int i = 0; i <_duration; i += 6)
        {

            Console.WriteLine("breath in...");
            SpinnerAnimation(3);
            Console.WriteLine("breath out...");
            SpinnerAnimation(3);

        }

        EndMessage();
    }

}

