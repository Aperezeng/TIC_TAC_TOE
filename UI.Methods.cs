namespace TIC_TAC_TOE;

public static class UI_Methods
{
  public static void DisplayWelcomeMessage()
  {
    Console.WriteLine("Welcome! First player to complete three symbols in a row wins!");  
  }

  public static void DisplayPlayerChoice()
  {
    Console.WriteLine("Which player would you like to be first? (1 or 2)"); 
  }
  
  public static void DisplayPlayersNumber()
  {
    int playerNumber = int.Parse(Console.ReadLine());
  }
  
  public static void DisplaySymbolsNumber()
  {
    int symbolNumber = int.Parse(Console.ReadLine());
  }
  
  public static void DisplaySymbolChoice()
  {
    Console.WriteLine("Choose between the symbols X or O");
  }
  
  public static void DisplaySymbol()
  {
    string symbol = Console.ReadLine().ToUpper();
  }
  
}