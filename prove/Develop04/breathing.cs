using System;

public class Breathing : Activity
{
    static string _activityName = "Breathing";
    static string _startMessage = "Here, we're gonna breathe real good. Breathe in and out slowly when I say.";
    static string _endMessage = "\n\nNice breathing, home dawg.";

    private void LoopBreathing()
    {
        Console.WriteLine("Get ready to breathe in.");
        WaitingAnimation(3);
        for (int i = 3; i > 0; i--)
        {  
            Console.Write(" \nBreathe in... ");
            for (int ii = 6; ii > 0; ii--)
            {
                Console.Write(ii);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
            Console.Write(" \nBreathe out...");
            for (int ii = 4; ii > 0; ii--)
            {
                Console.Write(ii);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
        }
        Console.Write(" ");
    }

    public Breathing() : base(_activityName, _startMessage, _endMessage)
    {
        Console.Clear();
        DisplayStartMessage();
        LoopBreathing();
        DisplayEndMessage();
        Console.ReadKey();
    }
    


}