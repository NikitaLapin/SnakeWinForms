using System;
using System.Collections;
using System.Drawing;
using System.Linq;

namespace Snake.AllGame
{
    public class Apple
    {
        private Random _random = new Random();
        public Point CurrentPosition;
        public int ItsNumber;

        public Apple(int previousNumber)
        {
            ItsNumber = previousNumber + 1;
        }

        public bool GenerateApple(IEnumerable enumerable)
        {
            const int numberOfCells = Globals.VerticalFieldSize * Globals.HorizontalFieldSize;
            if (ItsNumber > numberOfCells) return false;
            CurrentPosition.X = _random.Next(0, Globals.HorizontalFieldSize);
            CurrentPosition.Y = _random.Next(0, Globals.VerticalFieldSize);
            var enumerable1 = enumerable as object[] ?? enumerable.Cast<object>().ToArray();
            while (!IsCorrectApplePosition(enumerable1)) GenerateApple(enumerable1);
            ItsNumber++;
            return true;
        }

        private bool IsCorrectApplePosition(IEnumerable enumerable)
        {
            foreach (Body body in enumerable)
            {
                if (body.CurrentPosition == CurrentPosition) return false;
            }
            
            return true;
        }
    }
}