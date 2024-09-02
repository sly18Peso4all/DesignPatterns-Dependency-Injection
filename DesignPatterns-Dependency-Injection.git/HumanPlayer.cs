using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                string input = Console.ReadLine()!.ToUpper();

                switch (input)
                {
                    case "R":
                        playerChoice = Choice.Rock;
                        break;
                    case "P":
                        playerChoice = Choice.Paper;
                        break;
                    case "S":
                        playerChoice = Choice.Scissors;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, do try again");
                        break;
                };
            } while (true);

            return playerChoice;
        }
    }
}
