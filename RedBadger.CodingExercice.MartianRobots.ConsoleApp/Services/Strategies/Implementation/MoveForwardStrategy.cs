using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Strategies.Implementation
{
    internal class MoveForwardStrategy : IMoveStrategy
    {
        private IGridControllerService _gridControllerService;

        public MoveForwardStrategy(IGridControllerService gridControllerService)
        {
            _gridControllerService = gridControllerService;
        }

        public void Move(IRobot robot)
        {
            var x = robot.X;
            var y = robot.Y;

            // Next possible position
            MoveForward(ref x, ref y, robot.Direction);

            if (_gridControllerService.IsPositionOutsideGrid(x, y))
            {
                if (!_gridControllerService.IsPositionOfPastLostRobot(robot.X, robot.Y))
                {
                    robot.MarkAsLost();
                    _gridControllerService.AddLostRobotPosition(robot.X, robot.Y);      // Leave the scent behind
                }
            }
            else
            {
                robot.UpdatePosition(x, y);
            }
        }

        private void MoveForward(ref int x, ref int y, Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    y++;
                    break;
                case Direction.E:
                    x++;
                    break;
                case Direction.S:
                    y--;
                    break;
                case Direction.W:
                    x--;
                    break;
                default:
                    throw new InvalidOperationException("Unknown direction");
            }
        }
    }
}
