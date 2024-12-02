using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Implementation
{
    public class WorldRunnerService : IWorldRunnerService
    {
        private readonly IGridControllerService _gridControllerService;
        private readonly IRobotControllerService _robotControllerService;

        public WorldRunnerService(IGridControllerService gridControllerService, IRobotControllerService robotControllerService)
        {
            _gridControllerService = gridControllerService;
            _robotControllerService = robotControllerService;
        }

        public void Run() 
        {
            // Welcome message

            // 1. Grid
            var grid = GetGrid();
            _gridControllerService.InitialiseGrid(grid);

            // 2. Robots
            while (true)
            {
                var robot = GetNextRobotInitialState();
                var instructions = GetNextRobotInstructions();
                _robotControllerService.RunInstructions(robot, instructions);
                OutputRobotFinalState(robot);
            }
        }

        public static string GetTextRobotFinalState(IRobot robot)
        {
            return $"{robot.X} {robot.Y} {robot.Direction}{(robot.LostOutside ? " LOST" : "")}";
        }

        private void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to Martian robots world!");
        }

        private Grid GetGrid()
        {
            Console.WriteLine("Please enter limits for the grid:");
            var gridLimits = Console.ReadLine().Split(" ");
            Console.WriteLine("Grid created");

            return new Grid(int.Parse(gridLimits[0]), int.Parse(gridLimits[1]));
        }

        private IRobot GetNextRobotInitialState()
        {
            Console.WriteLine("Please enter robot details:");

            var robotParams = Console.ReadLine().Split(" ");
            Enum.TryParse(robotParams[2], out Direction direction);
            return new Robot(int.Parse(robotParams[0]), int.Parse(robotParams[1]), direction);
        }

        private string GetNextRobotInstructions()
        {
            return Console.ReadLine();
        }

        private void OutputRobotFinalState(IRobot robot)
        {
            Console.WriteLine(GetTextRobotFinalState(robot));
        }



    }
}
