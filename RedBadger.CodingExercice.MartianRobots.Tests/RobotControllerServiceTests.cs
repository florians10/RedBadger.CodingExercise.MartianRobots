using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Implementation;
using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types;
using Xunit.Microsoft.DependencyInjection;

namespace RedBadger.CodingExercice.MartianRobots.Tests
{
    public class RobotControllerServiceTests
    {
        /// <summary>
        /// Following the sample input and output from requirements
        /// </summary>
        [Fact]
        public void SampleTest()
        {
            // Setup
            var services = new ServiceCollection();
            DependencyInjection.Register(services);
            var provider = services.BuildServiceProvider();
            var robotService = provider.GetRequiredService<IRobotControllerService>();
            var gridService = provider.GetRequiredService<IGridControllerService>();
            gridService.InitialiseGrid(new Grid(5, 3));
            var robot1 = new Robot(1, 1, Direction.E);
            var robot2 = new Robot(3, 2, Direction.N);
            var robot3 = new Robot(0, 3, Direction.W);

            // Act - Assert
            robotService.RunInstructions(robot1, "RFRFRFRF");
            Assert.Equal("1 1 E", WorldRunnerService.GetTextRobotFinalState(robot1));

            robotService.RunInstructions(robot2, "FRRFLLFFRRFLL");
            Assert.Equal("3 3 N LOST", WorldRunnerService.GetTextRobotFinalState(robot2));

            robotService.RunInstructions(robot3, "LLFFFLFLFL");
            Assert.Equal("2 3 S", WorldRunnerService.GetTextRobotFinalState(robot3));

            // Final asserts
            Assert.True(gridService.IsPositionOfPastLostRobot(3 , 3));

        }

    }
}