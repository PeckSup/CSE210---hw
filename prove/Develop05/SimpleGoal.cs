using System;

public class SimpleGoal : EternalGoal
{
    protected bool _complete = false;
    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points)
    {
        _complete = complete;
    }

    public SimpleGoal() : base ()
    {
        _complete = false;
    }

    public override void DisplayGoal()
    {
        string icon = " ";
        if (_complete == true)
        {
            icon = "X";
        }
        Console.WriteLine($"{_name} [{icon}]");
    }

    public override void CalculatePoints(int totalPoints)
    {
        base.CalculatePoints(totalPoints);
        _complete = true;
    }




}