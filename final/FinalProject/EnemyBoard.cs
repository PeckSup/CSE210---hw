using System;

public class EnemyBoard : Board
{

    // On creation, place 3 ships. Player does not see these
    public EnemyBoard() : base()
    {
        PlaceShip(5);
        PlaceShip(4);
        PlaceShip(3);
    }

    protected override void PlaceShip(int size)
    {
        Random rd = new Random();
        bool empty;
        do
        {
            if (rd.Next(2) == 0) // place the ship horizonatally
            {
                // Grab a random coordinate to start on
                // we subtract the size of the ship from the possible x coordinate starting point
                int x = rd.Next(0, 10 - size);
                int y = rd.Next(0, 10);

                // place ship if there's room
                empty = TestPlacementHorizontal(x,y,size);
                if (empty)
                {
                    for(int j = x; j < x + size; j++) 
                    {
                        _board[y,j] = 1;
                    }
                }
            }

            else // place the ship vertically
            {
                // Grab a random coordinate to start on
                // we subtract the size of the ship from the possible y coordinate starting point
                int x = rd.Next(0, 10);
                int y = rd.Next(0, 10 - size);

                // place ship if there's room
                empty = TestPlacementVertical(x,y,size);
                if (empty == true)
                {
                    for(int j = y; j < y + size; j++) 
                    {
                        _board[j,x] = 1;
                    }
                }
            }
        }
        while (empty == false); // keep trying until an empty spot is found
    }

    // Enemy shoots a random spot that ahs not been shot yet
    public void EnemyShoot(Board playerBoard)
    {
        Random rd = new Random();
        int x;
        int y;
        do
        {
            x = rd.Next(0, 10);
            y = rd.Next(0, 10);
        } while (playerBoard.Shoot(x,y));

        // Display new board with the results
        playerBoard.DisplayBoard(true);
        Console.ReadKey();
    }


}