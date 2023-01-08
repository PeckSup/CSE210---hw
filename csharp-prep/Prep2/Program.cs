using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompt for grade from the user
        Console.WriteLine("How smart are you on a numerical sclae 1 through 100?");
        string response = Console.ReadLine();
        //Convert user response to int
        int grade = int.Parse(response);

        //Prepare program response. I use Write instead of WriteLine so I don't
        //have to store any variables.
        Console.Write("Mm. In that case, you get a");

        //Assign letter grade
        if (grade >= 90)
        {
            Console.Write("n A");
        }
        else if (grade >= 80)
        {
            Console.Write(" B");
        }
        else if (grade >= 70)
        {
            Console.Write(" C");
        }
        else if (grade >= 60)
        {
            Console.Write(" D");
        }
        else
        {
            Console.Write("n F");
        }

        //Assign + or - onto letter grade
        if (grade % 10 <= 3 && grade > 59)
        {
            Console.Write("-");
        }
        else if (grade % 10 >= 7 && grade > 50)
        {
            Console.Write("+");
        }
        else if (grade <= 20)
        {
            Console.Write("-");
        }

    }
}