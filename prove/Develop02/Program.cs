using System;
using System.IO;
class Program
{

    //Displays the options when the user opens to program
    static void DisplayOpeningOptions()
    {
        Console.WriteLine("\nHey, dawg. What're we up to today?");
        Console.WriteLine("Make sure you open any journals before writing if you want to add to it.");
        Console.WriteLine("1. Write with a prompt");
        Console.WriteLine("2. Write w/out a prompt");
        Console.WriteLine("3. Open a journal");
        Console.WriteLine("4. Read entries");
        Console.WriteLine("5. Save journal");
        Console.WriteLine("6. Quit");
    }

    // Gets response from user, returns the int number associated to each option
    // If the response in invalid, returns a 0.
    static int GetOpeningResponse()
    {
        string response = Console.ReadLine();
            int intResponse;
            try{
                intResponse = int.Parse(response);
            }
            catch {
                // if the response doesn't work, return a 0
                intResponse = 0;
            }
            return intResponse;
    }

    //
    //Get a random prompt from txt file
    static string GetPrompt()
    {
        //reads txt file and assigns it to array
        string[] journalPrompts = System.IO.File.ReadAllLines("JournalPrompts.txt");
        //pick a random number from 0 to # of prompts
        int numPrompts = journalPrompts.Length - 1;
        Random rd = new Random();
        int randNum = rd.Next(0,numPrompts);

        //return prompt
        Console.WriteLine("Here's your prompt:\n");
        return journalPrompts[randNum];

    }

    //
    //Records a new entry
    static Entry WriteNewEntry(Entry newEntry)
    {
        //record date and user entery
        string response = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        //assign recordings to an Entry and return it
        newEntry._entryDate = dateText;
        newEntry._response = response;
        return newEntry;
    }
    static void Main(string[] args)
    {        
        //prepare a new journal to write in
        //if an old journal is opened, it is added
        //to the *end* of this one.
        Journal journal = new Journal();
        int response;

        do
        {
            // Displays opening options
            DisplayOpeningOptions();
            // Gets the response as an int.
            response = GetOpeningResponse();
            
            // react to that resonse:
            switch (response)
            {
                case 1: // Get prompt(), display prompt, then write entry
                    Entry newEntry = new Entry();
                    newEntry._givenPrompt = GetPrompt();
                    Console.WriteLine(newEntry._givenPrompt);
                    newEntry = WriteNewEntry(newEntry);
                    //adds entry to journal
                    journal._journalEntries.Add(newEntry);
                    break;

                case 2: //Same as 1, but no prompt
                    Entry newEntry2 = new Entry();
                    Console.WriteLine(newEntry2._givenPrompt);
                    newEntry2 = WriteNewEntry(newEntry2);
                    journal._journalEntries.Add(newEntry2);
                    break;

                case 3:  //load a "journal" .txt file
                    Console.WriteLine("What's the name of the journal file?");
                    string journalName = Console.ReadLine();
                    try{
                        journal._journalName = journalName;
                        journal.LoadJournal();
                    }
                    catch {
                        // file name must be exact
                        Console.WriteLine("Sorry, I can't find a journal with that name.");
                    }
                    break;

                case 4: //Read current entries
                    journal.ReadJournal();
                    break;

                case 5: //Save the current entries as a "journal" file.
                        Console.WriteLine("Please name this journal:");
                        string fileName = Console.ReadLine();
                        journal._journalName = fileName;
                        journal.SaveJournal();
                        
                    break;

                case 6: // Quit
                    // prompts confirmation to avoid accidents.
                    Console.WriteLine("Are you sure you want to quit?");
                    Console.WriteLine("Any unsaved progress will be lost!");
                    Console.WriteLine("Type 'n' to go back");
                    string quit  = Console.ReadLine();
                    if (quit == "n"){
                        response = 0;
                    }
                    break;

                default: // no valid option
                    Console.WriteLine($"\nSorry, that's not a valid option.");
                    Console.WriteLine("Type 6 to quit.");
                    break;
            }
        }
        while(response !=6);
        

    }
}