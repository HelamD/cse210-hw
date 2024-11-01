using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),    // Running with distance in km
            new Cycling(new DateTime(2022, 11, 3), 60, 20.0),   // Cycling with speed in kph
            new Swimming(new DateTime(2022, 11, 3), 45, 30)     // Swimming with laps
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
    
