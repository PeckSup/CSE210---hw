using System;

public abstract class Board
{
    protected int[,] _board = new int[10,10];
    private string _hitMessage = "";
    private int _enemyHealth = 12;

    public Board()
    {
        // fills board with "empty" spaces, 0s
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                _board[i,j] = 0;
            }
        }
    }

    // checks for victory, victory is if the enemy health is at 0
    public bool CheckWin()
    {
        if (_enemyHealth == 0){
            return true;
        }
        else{
            return false;
        }
    }

    // Displays board, complete with row and column number headers
    // bool showShip lets us toggle whether ships are displayed or not
    public void DisplayBoard(bool showShip)
    {
        Console.Clear();
        Console.WriteLine("    0    1    2    3    4    5    6    7    8    9\n"); // Header

        // iterates through every square on the board and translates the integers
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i}  ");
            for (int j = 0; j < 10; j++)
            {
                char write = ' '; // default is blank
                switch (_board[i,j])
                {
                    case 1:
                        // only diplay ships if method argument is true
                        if (showShip == true){
                            write = 'S';
                        }
                        break;
                    case 2:
                        // display misses
                        write = '0';
                        break;
                    case 3:
                        // display hits
                        write = 'X';
                        break;
                }
                Console.Write($"[{write}]  ");
            }
            Console.Write("\n\n");
        }

        // display "miss" or "hit"
        Console.WriteLine($"\n{_hitMessage}\n");
    }

    // Player and Enemy boards place ships differently
    protected abstract void PlaceShip(int size);

    // shoots a board with the given x and y values
    // return true if the spot was already shot
    public bool Shoot(int x, int y)
    {
        switch (_board[y,x])
        {
            case 0:
                _board[y,x] = 2;
                _hitMessage = "Splooooosh! A miss!";
                return false;
            case 1:
                _board[y,x] = 3;
                _hitMessage = "KABOOOOOM!! A Hit!!";
                _enemyHealth -= 1;
                return false;
            default:
                return true;
        }
    }

    // test to make sure there is room on the baord for ship placement
    protected bool TestPlacementHorizontal(int x, int y, int size)
    {
        bool empty = true; // empty will flag if a ship is placed on a not empty square
        for(int j = x; j < x + size; j++) // check for empty squares
        {
            try
            {
                if (_board[y,j] != 0){
                    empty = false;
                }
            }
            catch{
                empty = false;
            }
        }
        return empty;
    }

    // test to make sure there is room on the baord for ship placement
    protected bool TestPlacementVertical(int x, int y, int size)
    {
        bool empty = true; // empty will flag if a ship is placed on a not empty square
        for(int j = y; j < y + size; j++) // check for empty squares
        {
            try
            {
                if (_board[j,x] != 0){
                    empty = false;
                }
            }
            catch{
                empty = false;
            }
        }
        return empty;
    }
}