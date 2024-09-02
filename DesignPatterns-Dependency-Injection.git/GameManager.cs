using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Dependency_Injection.git
{
    public class GameManager
    {
        private IPlayer _player1;

        private IPlayer _player2;

        public GameManager(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public RoundResult PlayRound()
        {
            Choice playerOne = _player1.GetChoice();

            Choice playerTwo = _player2.GetChoice();

            Console.WriteLine($"Player 1 picks {playerOne.ToString()} and Player 2 picks {playerTwo.ToString()} ");
           

            if (playerOne == playerTwo)
            {
                return RoundResult.Draw;
            }

            if (playerOne == Choice.Rock && playerTwo == Choice.Scissors || 
                playerOne == Choice.Paper && playerTwo == Choice.Rock ||
                playerOne == Choice.Scissors && playerTwo == Choice.Paper)
            {
                return RoundResult.PlayerOneWins;
            }

            return RoundResult.PlayerTwoWins;
        }
    }
}
