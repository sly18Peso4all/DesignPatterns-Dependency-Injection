using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Dependency_Injection.git
{
    public class ComputerPlayer : IPlayer
    {
        private Random randomNumberGenerator = new Random();

        public Choice GetChoice()
        {
            Choice computerPlayer = (Choice)randomNumberGenerator.Next(0, 3);

           return computerPlayer;
        }
    }
}
