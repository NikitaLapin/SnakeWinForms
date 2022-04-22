using System.Collections;
using System.Drawing;

namespace Snake.AllGame
{
    public class Snake : IEnumerable
    {
        public readonly Body SnakeHead;

        public Snake()
        {
            SnakeHead = new Body(Direction.Directions.Forward, new Point(Globals.HorizontalFieldSize/2, Globals.VerticalFieldSize/2));
        }

        public void Move(Direction.Directions direction)
        {
            var positionToMove = new Point(SnakeHead.CurrentPosition.X, SnakeHead.CurrentPosition.Y);
            FindNewLocationOfHead(ref positionToMove, direction);
            SnakeHead.Move(positionToMove);
        }

        public IEnumerator GetEnumerator()
        {
            var currentBody = SnakeHead;
            while (currentBody != null)
            {
                yield return currentBody;
                currentBody = currentBody.NextBody;
            }
        }

        private void FindNewLocationOfHead(ref Point positionToMove, Direction.Directions direction)
        {
            switch (direction)
            {
                case Direction.Directions.Forward:
                    positionToMove.Y--;
                    break;
                case Direction.Directions.Left:
                    positionToMove.X--;
                    break;
                case Direction.Directions.Back:
                    positionToMove.Y++;
                    break;
                case Direction.Directions.Right:
                    positionToMove.X++;
                    break;
            }
        }

        public void AddNewBody()
        {
            var tail = SnakeHead.FindTail();
            tail.NextBody = new Body(tail.CurrentDirection, tail.PreviousPosition);
        }
    }
}