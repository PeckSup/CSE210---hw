using System;

// An Entry is a date, a "prompt", and a user response.
public class Entry
{
    public string _entryDate = "";
    public string _givenPrompt = "No Prompt";
    public string _response = "";
    
    // displays the entry
    public void DispayEntry()
    {
        Console.Write($"\n{_entryDate} - ");
        Console.WriteLine(_givenPrompt);
        Console.WriteLine($"\n{_response}\n");
    }
}