using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services
{
    public interface IRobotControllerService
    {
        public void RunInstructions(IRobot robot, string instructions);
    }
}
