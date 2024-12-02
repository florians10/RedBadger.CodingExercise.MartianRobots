using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Strategies.Implementation
{
    internal class MoveRightStrategy : IMoveStrategy
    {
        public void Move(IRobot robot)
        {
            var direction = robot.Direction switch
            {
                Direction.N => Direction.E,
                Direction.E => Direction.S,
                Direction.S => Direction.W,
                Direction.W => Direction.N,
                _ => robot.Direction
            };
            robot.UpdateDirection(direction);
        }
    }
}
