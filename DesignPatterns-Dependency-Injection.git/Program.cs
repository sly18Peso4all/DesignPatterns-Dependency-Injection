
using DesignPatterns_Dependency_Injection.git;


GameManager gameManager = new GameManager(new HumanPlayer(), new ComputerPlayer());

do
{
    RoundResult result = gameManager.PlayRound();

    if (result == RoundResult.PlayerOneWins)
    {
        Console.WriteLine("Player 1 Wins!");
    }
    else if (result == RoundResult.PlayerTwoWins)
    {
        Console.WriteLine("Player 2 Wins!");
    }
    else { Console.WriteLine("Its a draw!"); }

    Console.WriteLine("Play Again (Y/N)? ");

} while (Console.ReadLine() == "Y");
