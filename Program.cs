using System;

internal class Program
{
    public static void Main(string[] args)
    {
        int ROWS = 3;
        int COLUMNS = 3;
        int[,] gameBoard = new int[ROWS, COLUMNS];
        string horizontalBorder = "----+---+---";
        string verticalBorder = "|   |   |   |";
        for (int i = 0; i < ROWS; i++)
        {
            Console.WriteLine(horizontalBorder);
            for (int j = 0; j < COLUMNS - 1; j++)
            {
                Console.WriteLine(verticalBorder); 
            }
        }
        Console.WriteLine(horizontalBorder);
    }
}


      