using RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types;

namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Services.Implementation
{
    /// <summary>
    /// Grid service to keep hold of the limits and history of the grid
    /// </summary>
    internal class GridControllerService : IGridControllerService
    {
        private Grid _grid { get; set; }

        public void AddLostRobotPosition(int x, int y)
        {
            _grid.LostSpots.Add((x, y));
        }

        public void InitialiseGrid(Grid grid)
        {
            _grid = grid;
        }

        public bool IsPositionOfPastLostRobot(int x, int y)
        {
            return _grid.LostSpots.Contains((x, y));
        }

        public bool IsPositionOutsideGrid(int x, int y)
        {
            return (x < 0 || x > _grid.BoundryX || y < 0 || y > _grid.BoundryY) ;
        }
    }
}
