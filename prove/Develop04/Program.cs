using System;

class Program
{
    static string OpeningPrompt()
    {
        Console.Clear();
        Console.WriteLine("Hola, and welcome to the activity center.");
        Console.WriteLine("Forgive the lack of music, I'm afraid my CDs are all scratched.");
        Console.WriteLine("\nUh, anyway, what're we up to today?");
        Console.WriteLine("1. Breathing \n2. Reflecting \n3. Listing \n4. Quitting");

        string response = Console.ReadLine();
        return response;
    }

    static bool PickActivity(string option)
    {
        int choice;
        try {
            choice = int.Parse(option);
        }
        catch{
            choice = 5;
        }

        switch (choice)
        {
            case 1:
                Breathing breathing = new Breathing();
                break;
            case 2:
                Reflection reflection = new Reflection();
                break;
            case 3:
                Listing Listing = new Listing();
                break;
            case 4:
                return false;
            default:
                Console.WriteLine("That... is... not...\nIf you want to quit, type 4");
                Console.ReadKey();
                break;
        }
        return true;
    }


    static void Main(string[] args)
    {
        string response;
        do{
        response = OpeningPrompt();
        }
        while(PickActivity(response));
    }
}