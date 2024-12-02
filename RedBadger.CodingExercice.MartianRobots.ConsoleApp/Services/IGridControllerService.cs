using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services
{
    public interface IGridControllerService
    {
        void InitialiseGrid(Grid grid);

        bool IsPositionOutsideGrid(int x, int y);

        bool IsPositionOfPastLostRobot(int x, int y);

        void AddLostRobotPosition(int x, int y);
    }
}
