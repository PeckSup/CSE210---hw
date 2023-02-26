using System;

public class Listing : Activity
{
    static string _activityName = "Listing";
    static string _startMessage = "Nothing makes a fun Saturday afternoon quite like a list, eh?";
    static string _endMessage = "\n\nNice reciting, home dawg.";

    private string GetPrompt(string filename)
    {
        //reads txt file and assigns it to array
        string[] prompts = System.IO.File.ReadAllLines(filename);
        //pick a random number from 0 to # of prompts
        int numPrompts = prompts.Length - 1;
        Random rd = new Random();
        int randNum = rd.Next(0,numPrompts);

        //return prompt
        return prompts[randNum];
    }

    private void ShowPrompt(int duration)
    {
        Console.Clear();
        string prompt = GetPrompt("ListingPrompts.txt");
        Console.WriteLine($"List as many responses as you can to the following prompt:\n\n\n{prompt}");

        Console.WriteLine("You begin in...\n");
        for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
            }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        int count = 0;
        Console.WriteLine(" \n");
        do
        {
            Console.ReadLine();
            count++;
        }
        while (DateTime.Now < endTime);
        Console.WriteLine($"\nYowzers! You listed {count} items!");
    }

    public Listing() : base(_activityName, _startMessage, _endMessage)
    {
        Console.Clear();
        DisplayStartMessage();
        int duration = GetDuration();
        ShowPrompt(duration);
        DisplayEndMessage();
        Console.ReadKey();
    }

}