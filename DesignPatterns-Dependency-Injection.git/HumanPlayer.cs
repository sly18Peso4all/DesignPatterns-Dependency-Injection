
namespace DesignPatterns_Dependency_Injection.git
{
    public class HumanPlayer : IPlayer
    {
        public Choice GetChoice()
        {
            Choice playerChoice;

            do
            {
                Console.WriteLine("Enter Choice: Rock (R), Paper (P) or Scissors (S) : ");

                string input = Console.ReadLine().ToUpper();

                if (input == "R")
                {
                    playerChoice = Choice.Rock;
                    break;
                }
                else if (input == "P")
                {
                    playerChoice = Choice.Paper;
                    break;
                }
                else if (input == "S")
                {
                    playerChoice = Choice.Scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again");
                }

            } while (true);

            return playerChoice;
        }
    }
}
