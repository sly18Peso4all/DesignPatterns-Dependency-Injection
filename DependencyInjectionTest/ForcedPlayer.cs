using DesignPatterns_Dependency_Injection.git;


namespace DependencyInjectionTest
{
    public class ForcedPlayer : IPlayer
    {
        private Choice _choice;

        public ForcedPlayer(Choice choice)
        {
            _choice = choice;
        }

        public Choice GetChoice()
        {
            return _choice;
        }
    }
}
