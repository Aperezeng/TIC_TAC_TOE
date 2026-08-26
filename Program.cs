using System;
using TIC_TAC_TOE;

internal class Program
{
    public static void Main (string[] args)
    {
        UI_Methods.DisplayWelcomeMessage();
        UI_Methods.DisplayPlayer("1", "2");
        UI_Methods.DisplaySymbolChoices();
        UI_Methods.EnterSymbol();
        UI_Methods.ValidateSymbol();
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