using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Dependency_Injection.git
{
    public class ClusteredGameManager
    {
        Random _rng = new Random();
        public RoundResult PlayRound()
        {
            Choice p1;

            do
            {
                Console.WriteLine("Enter Choice: Rock (R), Paper (P) or Scissors (S) : ");

                string input = Console.ReadLine().ToUpper();

                if (input == "R")
                {
                    p1 = Choice.Rock;
                    break;
                }
                else if (input == "P")
                {
                    p1 = Choice.Paper;
                    break;
                }
                else if (input == "S")
                {
                    p1 = Choice.Scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again");
                }

            } while (true);

            
            Choice p2 = (Choice)_rng.Next(0, 3);

            if (p1 == p2)
            {
                return RoundResult.Draw;
            }

            if (p1 == Choice.Rock && p2 == Choice.Scissors ||
                p1 == Choice.Paper && p2 == Choice.Rock ||
                p1 == Choice.Scissors && p2 == Choice.Paper)
            {
                return RoundResult.PlayerOneWins;
            }

            return RoundResult.PlayerTwoWins;
        }
    }
}
