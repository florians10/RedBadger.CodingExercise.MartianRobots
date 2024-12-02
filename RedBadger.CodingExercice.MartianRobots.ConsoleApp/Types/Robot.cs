namespace RedBadger.CodingExercice.MartianRobots.ConsoleApp.Types
{
    public class Robot : IRobot
    {
        public int X { get; private set; }  
        public int Y { get; private set; }
        public Direction Direction { get; private set; }
        public bool LostOutside { get; private set; }

        public Robot(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void UpdatePosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void UpdateDirection(Direction direction)
        { 
            this.Direction = direction;
        }
        public void MarkAsLost()
        {
            LostOutside = true;
        }
    }

    public interface IRobot
    {
        public int X { get; }
        public int Y { get; }
        public Direction Direction { get; }
        public bool LostOutside { get; }

        public void UpdatePosition(int x, int y);

        public void UpdateDirection(Direction direction);

        public void MarkAsLost();
    }

}
