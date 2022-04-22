namespace Snake.AllGame
{
    public class Update
    {
        public bool IsUpdated;
        public readonly Direction.Directions NewDirection;

        public Update(Direction.Directions newDirection, bool isUpdated)
        {
            NewDirection = newDirection;
            IsUpdated = isUpdated;
        }
        
    }
}