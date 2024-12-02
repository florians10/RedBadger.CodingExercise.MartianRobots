using Microsoft.Extensions.DependencyInjection;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Strategies;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Implementation
{
    /// <summary>
    /// Robot service which deals with running the set of instructions - until of course the robot gets lost
    /// </summary>
    public class RobotControllerService : IRobotControllerService
    {
        private readonly IServiceProvider _keyedServiceProvider;
        public RobotControllerService(IServiceProvider keyedServiceProvider)
        {
            _keyedServiceProvider = keyedServiceProvider;
        }

        public void RunInstructions(IRobot robot, string instructions)
        {
            foreach (var instruction in instructions)
            {
                var moveStrategy = _keyedServiceProvider.GetKeyedService<IMoveStrategy>(instruction);
                moveStrategy?.Move(robot);
                if(robot.LostOutside)
                {
                    return;
                }
            }
        }
    }
}
