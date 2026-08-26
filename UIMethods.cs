namespace TIC_TAC_TOE;
public class UI_Methods
{
  public static void DisplayWelcomeMessage()
  {
    Console.WriteLine("Welcome! First player to complete three symbols in a row wins!");  
  }

  public static void DisplayPlayer(string playerOne, string playerTwo)
  {
    Console.WriteLine($"Hello there. you will be player #{playerOne}. PC will be player #{playerTwo}. Let's get started!"); 
  }
  
  public static void DisplaySymbolChoices()
  {
    Console.WriteLine("Choose between the symbols X or O");
  }
  public static void EnterSymbol()
  {
    Console.WriteLine("Please enter your symbol choice: ");
    string symbol = Console.ReadLine().ToUpper();
    UI_Methods.symbol = symbol;
  }
  public static string symbol { get; set; }
  public static void ValidateSymbol()
  {
    while (symbol != "X" && symbol != "O")
    {
      Console.WriteLine("Invalid symbol. Please choose either X or O.");
      EnterSymbol();
    }
    Console.WriteLine($"You have chosen {symbol} as your symbol.");
  }
}
