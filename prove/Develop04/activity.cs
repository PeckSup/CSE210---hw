using System;

public class Activity
{
    private string _startingMessage = "No starting message";
    private string _activityName = "No activity name";
    private string _endMessage = "No end message";

    public Activity(string name, string startMessage, string endMessage)
    {
        _activityName = name;
        _startingMessage = startMessage;
        _endMessage = endMessage;
    }

    protected int GetDuration()
    {
        Console.WriteLine("For how many seconds are we gonna go ham today?");
        string seconds  = Console.ReadLine();
        try 
        {
            int _duration = int.Parse(seconds);
            return _duration;
            }
        catch {
            Console.WriteLine("Sorry, I can't count to that, I don't think");
            return 0;
        }
    }

    public void WaitingAnimation(int seconds)
    {
        int iteration = 0;
        int i = iteration % 4;
        char icon = '-';
        int milliseconds = seconds * 1000;
        while (milliseconds > 0)
        {
            switch (i)
            {
                case 0:
                    icon = '|';
                    break;
                case 1:
                    icon = '/';
                    break;
                case 2:
                    icon = '-';
                    break;
                case 3:
                    icon = '\\';
                    break;
            }
            
            Console.Write(icon);
            Thread.Sleep(500);
            Console.Write("\b");
            milliseconds -= 500;
            iteration +=1;
            i = iteration % 4;
        }
    }

    protected void DisplayStartMessage(){
        Console.WriteLine($"Welcome to the {_activityName} activity. \n{_startingMessage}");
    }

    protected void DisplayEndMessage(){
        Console.WriteLine(_endMessage);
    }

}