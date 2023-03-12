using System;


/*
Unfortunately, I did not have time to finish this assigment. If I get it finished, I will resubmit it on convas.

The classes are there, but I've been struggling to get an array of the classes to work. It refuses to append. 

I also don't have the ability to save or load right now. Everything else is in place, though that's like half the assingment.

*/
class Program
{
    static string OpeningPrompt(int totalPoints)
    {
        Console.Clear();
        Console.WriteLine($"Current points: {totalPoints}");
        Console.WriteLine("What're we up to today?");
        Console.WriteLine("1. List / Record Goals \n2. Save Goals \n3. Load Goals \n4. Create New Goal \n5. Quit");

        string response = Console.ReadLine();
        return response;
    }

    static void ListGoals(EternalGoal[] goalArray)
    {
        foreach (EternalGoal goal in goalArray)
        {
            goal.DisplayGoal();
        }
    }

    static void CreateGoal(EternalGoal[] goalArray)
    {
        Console.WriteLine("What kind of goal do you want to create?");
        Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal.");

        string response = Console.ReadLine();
        int choice;
        try {
            choice = int.Parse(response);
        }
        catch{
            choice = 6;
        }

        switch (choice)
        {
            case 1:
                SimpleGoal Sgoal = new SimpleGoal();
                goalArray.Append(Sgoal);
                break;
            case 2:
                EternalGoal Egoal = new EternalGoal();
                goalArray.Append(Egoal);
                break;
            case 3:
                ChecklistGoal Cgoal = new ChecklistGoal();
                goalArray.Append(Cgoal);
                break;
            default:
                Console.WriteLine("Invalid answer");
                break;
        }
    }



    static bool PickActivity(string option, EternalGoal[] goalArray)
    {
        int choice;
        try {
            choice = int.Parse(option);
        }
        catch{
            choice = 6;
        }

        switch (choice)
        {
            case 1:
                ListGoals(goalArray);
                Console.ReadKey();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                CreateGoal(goalArray);
                break;
            case 5:
                return true;
            default:
                Console.WriteLine("That... is... not...\nIf you want to quit, type 5");
                Console.ReadKey();
                break;
        }
        return false;
    }
    static void Main(string[] args)
    {
        int totalPoints = 0;
        bool quit = false;
        EternalGoal[] goalArray = {};
        while (!quit)
        {
            string Choice = OpeningPrompt(totalPoints);
            quit = PickActivity(Choice, goalArray);
        }
    }
}