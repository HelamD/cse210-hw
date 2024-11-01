using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;
    
    static void Main(string[] args)
    {
        LoadGoalsFromFile();

        bool running = true;
        while (running)
        {

            Console.Clear();
            DisplayGoals();

            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a new goal");
            Console.WriteLine("2. Record progress");
            Console.WriteLine("3. Save and exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddGoal();
            }
            else if (choice == "2")
            {
                RecordGoalProgress();
            }
            else if (choice == "3")
            {
                SaveGoalsToFile();
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }


    static void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetGoalInfo());
        }
        Console.WriteLine($"\nTotal Points: {totalPoints}");
    }

    static void AddGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Choose goal type (1 = Simple, 2 = Eternal, 3 = Checklist): ");
        string choice = Console.ReadLine();
        Goal newGoal = null;

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
            newGoal = new SimpleGoal(name, points);
        else if (choice == "2")
            newGoal = new EternalGoal(name, points);
        else if (choice == "3")
        {
            Console.Write("Enter target count for checklist: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            newGoal = new Checklist(name, points, targetCount, bonusPoints);
        }

        if (newGoal != null)
        {
            goals.Add(newGoal);
            Console.WriteLine("Goal added!");
        }
    }

    static void RecordGoalProgress()
    {
        Console.WriteLine("Enter the number of the goal to record progress:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= goals.Count)
        {
            Goal goal = goals[index - 1];
            goal.RecordProgress();
            totalPoints += goal.Points;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void SaveGoalsToFile()
    {
        string filename = "goals.txt";
        List<string> lines = new List<string>();

        foreach (Goal goal in goals)
        {
            lines.Add(goal.SaveGoal());
        }
        File.WriteAllLines(filename, lines);
    }

     static void LoadGoalsFromFile()
    {
        string filename = "goals.txt";
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                int points = int.Parse(parts[1]);
                bool isCompleted = bool.Parse(parts[2]);

                if (parts.Length == 3)
                    goals.Add(new SimpleGoal(name, points));
                else if (parts.Length == 5)
                {
                    int currentCount = int.Parse(parts[3]);
                    int targetCount = int.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);
                    var checklist = new Checklist(name, points, targetCount, bonusPoints);
                    checklist.CurrentCount = currentCount;
                    goals.Add(checklist);
                }
            }
        }
    }
}

    


            
