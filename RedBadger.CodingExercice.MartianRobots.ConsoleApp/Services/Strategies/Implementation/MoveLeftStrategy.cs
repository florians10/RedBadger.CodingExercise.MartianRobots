using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Strategies.Implementation
{
    internal class MoveLeftStrategy : IMoveStrategy
    {
        public void Move(IRobot robot)
        {
            var direction = robot.Direction switch
            {
                Direction.N => Direction.W,
                Direction.W => Direction.S,
                Direction.S => Direction.E,
                Direction.E => Direction.N,
                _ => robot.Direction
            };
            robot.UpdateDirection(direction);
        }
    }
}
