using System;

class Program
{
    static void Main(string[] args)
    {
        // create the boards and place the ships
        EnemyBoard enemyBoard = new EnemyBoard();
        PlayerBoard playerBoard = new PlayerBoard();

        // take turns shooting,
        // ends when someone wins
        while (true)
        {
            playerBoard.PlayerShoot(enemyBoard);
            if (enemyBoard.CheckWin())
            {
                Console.WriteLine("You win!!!!");
                Console.ReadKey();
                return;
            }

            enemyBoard.EnemyShoot(playerBoard);
            if(playerBoard.CheckWin())
            {
                Console.WriteLine("Dang, you lose.");
                Console.ReadKey();
                return;
            }

        }
    }
}