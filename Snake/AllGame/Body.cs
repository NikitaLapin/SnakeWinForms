using System.Drawing;

namespace Snake.AllGame
{
    public class Body
    {
        public Point CurrentPosition;
        public Point PreviousPosition;
        public Direction.Directions CurrentDirection;
        public Body NextBody = null;

        public Body(Direction.Directions newDirection, Point newPosition)
        {
            CurrentDirection = newDirection;
            CurrentPosition = newPosition;
            PreviousPosition = CurrentPosition;
        }

        public void Move(Point position)
        {
            NextBody?.Move(CurrentPosition);
            PreviousPosition = CurrentPosition;
            CurrentPosition = position;
        }

        public bool isOnHead(Point positionOfHead)
        {
            if (positionOfHead == CurrentPosition) return true;
            return NextBody != null && NextBody.isOnHead(positionOfHead);
        }

        public Body FindTail()
        {
            return NextBody != null ? NextBody.FindTail() : this;
        }
    }
}