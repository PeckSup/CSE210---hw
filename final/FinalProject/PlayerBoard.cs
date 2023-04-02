using System;

public class PlayerBoard : Board
{

    // On creation, player places 3 ships
    public PlayerBoard() : base()
    {
        PlaceShip(5);
        PlaceShip(4);
        PlaceShip(3);
    }

    protected override void PlaceShip(int size)
    {
        DisplayBoard(true);
        Console.Write($"This ship is {size} spaces long. ");
        bool valid = true;
        while (valid)
        {
            bool response = PromptDirection(); // True is horizontall, False is vertical

            // Prompt for ship coordinates
            Console.WriteLine("Enter the X Coordinate for the top left of the ship");
            int x = PromptCoordinate();
            Console.WriteLine("Now enter the Y Coordinate for the same");
            int y = PromptCoordinate();

            // IF horizontal and it fits
            if(response && TestPlacementHorizontal(x,y,size)) 
            {
                for(int j = x; j < x + size; j++) 
                    {
                        _board[y,j] = 1;
                    }
                return;
            }
             // IF and it fits
            else if (!response && TestPlacementVertical(x,y,size))
            {
                for(int j = y; j < y + size; j++) 
                    {
                        _board[j,x] = 1;
                    }
                return;
            }
            else{
                Console.WriteLine("Sorry, the ship is too fat for that location.");
            }
        }
    }

// Prompts for placement direction
// True is horizontal, false is vertical
    private bool PromptDirection() 
    { 
        Console.WriteLine("Do you want this horizontal (H) or vertical (V)?");
        while (true)
        {
            string response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "H" || response == "HORIZONTAL"){
                return true;
            }
            else if (response == "V" || response == "VERTICAL"){
                return false;
            }
            else
            {
                Console.WriteLine("Hint: type a valid response");
            }
        }
    }

// Prompts for a coordinate, tries until user enters a number 0-9
    private int PromptCoordinate()
    {
        int x = 10;
        do {
            string response = Console.ReadLine();
            try{
                x = int.Parse(response);
            }
            catch {}
            if (9 < x || x < 0)
            {
                Console.WriteLine("Enter a valid number 0-9");
            }
        } while (9 < x || x < 0);

        return x;
    }

// player shoots the enemy board
    public void PlayerShoot(Board enemyBoard)
    {
        // display enemy board then prompt
        enemyBoard.DisplayBoard(false);
        Console.WriteLine("Where do you wanna shoot?");
        
        // do until a valid response is given
        bool valid = true;
        do {
            Console.WriteLine("Enter the X coordinate: ");
            int x = PromptCoordinate();
            Console.WriteLine("Enter the Y coordinate: ");
            int y = PromptCoordinate();

            valid = enemyBoard.Shoot(x,y);
            if (valid){
                Console.WriteLine("You've... already shot there?");
            }

        } while (valid);

        // display new board with the results
        enemyBoard.DisplayBoard(false);
        Console.ReadKey();
    }

}