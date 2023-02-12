using System;

class Program
{
    // prompt user and return bool
    static bool Prompt()
    {
        string input = Console.ReadLine();
        if (input == "quit"){
            return true;
        }
        return false;
    }

    static void Main(string[] args)
    {

        string reference = "James 1:5-6";

        string scriptureText1 = "If any of you lack wisdom, let him ask of God, ";
        scriptureText1 += "that giveth to all men liberally, and upbraideth not; and it shall be given him.";

        string scriptureText2 = "But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";

        // assign the above scripture to 2 verse objects
        Verse verse5 = new Verse(scriptureText1, 5);
        Verse verse6 = new Verse(scriptureText2, 6);
        
        // put the verses in a scripture
        Scripture scriptureMastery = new Scripture(reference);
        scriptureMastery.AddVerse(verse5);
        scriptureMastery.AddVerse(verse6);


        // delete words until they run out or use says quit
        bool quit = false;
        while (quit == false)
        {
            // it will alsways display at least once
            scriptureMastery.DisplayScripture();
            Console.WriteLine($"\nType \"quit\" to quit.");

            // prompt for quit
            quit = Prompt();
            // quit anyway if no more words
            if (scriptureMastery.ScriptureWordsRemaining() == 0){
                quit = true;
            }

            // if we're not quitting, delete words and clear the screen
            if (!quit)
            {
                scriptureMastery.DeleteWords();
                Console.Clear();
            }

        }   

        

    }
}