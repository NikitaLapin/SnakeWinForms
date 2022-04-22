using System.Windows.Forms;

namespace Snake.AllGame
{
    public static class Direction
    {
        public enum Directions
        {
            Forward = 0, Left = 1, Back = 2, Right = 3, Stop = 99
        }

        public static bool IsAbleToTurn(Directions firstDirection, Directions secondDirection)
        {
            switch (firstDirection)
            {
                case Directions.Forward : case Directions.Back:
                    if (secondDirection == Directions.Left || secondDirection == Directions.Right) return true;
                    return false;
                case Directions.Left : case Directions.Right:
                    if (secondDirection == Directions.Back || secondDirection == Directions.Forward) return true;
                    return false;
                case Directions.Stop:
                    return true;
                default: return false;
            }
        }

        public static bool ConvertKeyToDirection(char key, ref Directions direction)
        {
            switch (key)
            {
                case 'w':
                    direction = Directions.Forward;
                    return true;
                case 'a':
                    direction = Directions.Left;
                    return true;
                case 's':
                    direction = Directions.Back;
                    return true;
                case 'd':
                    direction = Directions.Right;
                    return true;
                case (char)Keys.Escape:
                    direction = Directions.Stop;
                    return true;
            }

            return false;
        }
    }
}