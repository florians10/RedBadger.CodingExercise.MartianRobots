namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types
{
    public class Grid
    {
        public int BoundryX { get; set; }
        public int BoundryY { get; set; }

        public HashSet<(int, int)> LostSpots { get; private set; }

        public Grid(int x, int y) {
            BoundryX = x; 
            BoundryY = y;
            LostSpots = new HashSet<(int, int)>();
        }
    }
}
