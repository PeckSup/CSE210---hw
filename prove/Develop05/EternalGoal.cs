using System;

public class EternalGoal
{
    protected string _name = "";
    private string _description = "";
    private int _points = 0;

    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    protected int TestNumber(string input)
    {
        int number = 0;
        try {
            number = int.Parse(input);
        }
        catch 
        {
            Console.WriteLine("I'm sorry, that is not a valid number");
            return 0;
        }
        return number;
    }

    public EternalGoal()
    {
        Console.WriteLine("What do you want to name this goal?\n");
        _name = Console.ReadLine();
        Console.WriteLine("And what short description should we add to that?\n");
        _description = Console.ReadLine();

        while (_points == 0)
        {
            Console.WriteLine("And for how many points will this be worth on completion?");
            string pointsString = Console.ReadLine();
            _points = TestNumber(pointsString);
        }
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine("please");
        Console.WriteLine($"{_name}");
    }

    public virtual void CalculatePoints(int totalPoints)
    {
        totalPoints += _points;
    }
}