using System;

public class Reflection : Activity
{
    static string _activityName = "Reflection";
    static string _startMessage = "It's time to get all nostalgic in this his-ouse";
    static string _endMessage = "\n\nNice pondering, home dawg.";

    private string GetPrompt(string filename)
    {
        //reads txt file and assigns it to array
        string[] prompts = System.IO.File.ReadAllLines(filename);
        //pick a random number from 0 to # of prompts
        int numPrompts = prompts.Length - 1;
        Random rd = new Random();
        int randNum = rd.Next(0,numPrompts);

        //return prompt
        Console.WriteLine("Here's your prompt:\n");
        return prompts[randNum];
    }

    private void ShowPrompt(int duration)
    {
        string prompt = GetPrompt("ReflectionPrompts.txt");

        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n\n~~~ Think back to when you {prompt} ~~~");

        Console.WriteLine("When you're ready, hit anything, and we will begin.");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("How did this experience make you feel?");
        WaitingAnimation(duration / 2);
        Console.WriteLine("Would you have behaved differently, looking back?");
        WaitingAnimation(duration / 2);
    }

    public Reflection() : base(_activityName, _startMessage, _endMessage)
    {
        Console.Clear();
        DisplayStartMessage();
        int duration = GetDuration();
        ShowPrompt(duration);
        DisplayEndMessage();
        Console.ReadKey();
    }
}