using System;

public class ChecklistGoal : SimpleGoal
{
    private int _amount = 1;
    private int _rewardPoints = 0;
    private int _progress = 0;

    public ChecklistGoal(string name, string description, int points, bool complete, int amount, int rewardPoints, int progress) : base(name, description, points, complete)
    {
        _amount = amount;
        _rewardPoints = rewardPoints;
    }

    public ChecklistGoal () : base ()
    {
        Console.WriteLine("How many times do you wnat to accomplish this?\n");
        string stringAmount = Console.ReadLine();
        _amount = TestNumber(stringAmount);
        Console.WriteLine("What bonus points should you get for completeing meeting your goal amount?\n");
        string stringReward = Console.ReadLine();
        _rewardPoints = TestNumber(stringReward);
    }

    public override void CalculatePoints(int totalPoints)
    {
        base.CalculatePoints(totalPoints);
        _progress += 1;
        if(_progress == _amount)
        {
            totalPoints += _rewardPoints;
        }
    }
}