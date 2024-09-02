using DesignPatterns_Dependency_Injection.git;
using NUnit.Framework;

namespace DependencyInjectionTest
{
   public class RockPaperScissorsTest
    {
        [Test]
        public void RockBeatsScissors()
        {
            GameManager gameManager = new GameManager(new ForcedPlayer(Choice.Rock), new ForcedPlayer(Choice.Scissors));

            Assert.That(gameManager.PlayRound(), Is.EqualTo(RoundResult.PlayerOneWins));
        }
    }
}