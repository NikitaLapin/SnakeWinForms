using System.Drawing;

namespace Snake.AllGame
{
    public class VisualController
    {
        private enum Flags{Empty, Apple, Snake, SnakeHead}
        private readonly Flags[,] _currentField = new Flags[Globals.HorizontalFieldSize, Globals.VerticalFieldSize];
        public Bitmap UpdatedField;
        
        
        public void MakeFieldEmpty()
        {
            for (var i = 0; i < Globals.HorizontalFieldSize; i++)
            {
                for (var j = 0; j < Globals.VerticalFieldSize; j++)
                {
                    _currentField[i, j] = Flags.Empty;
                }
            }
        }
        public void AddSnakeHead()
        {
            const int verticalMid = (Globals.VerticalFieldSize - 1) / 2;
            const int horizontalMid = (Globals.HorizontalFieldSize - 1) / 2;
            _currentField[horizontalMid, verticalMid] = Flags.SnakeHead;
        }
        public void AddApple(Point applePosition)
        {
            _currentField[applePosition.X, applePosition.Y] = Flags.Apple;
        }
        public void DeleteApple(Point applePosition)
        {
            _currentField[applePosition.X, applePosition.Y] = Flags.Empty;
        }
        public void AddSnake(Body body)
        {
            if (body.NextBody != null) AddSnake(body.NextBody);
            _currentField[body.CurrentPosition.X, body.CurrentPosition.Y] = Flags.Snake;
        }
        public void MakeFirstAHead(Body body)
        {
            _currentField[body.CurrentPosition.X, body.CurrentPosition.Y] = Flags.SnakeHead;
        }
        public void CorrectBitmap()
        {
            UpdatedField = new Bitmap(Globals.HorizontalFieldSize * Globals.SizeOfCell,
                Globals.VerticalFieldSize * Globals.SizeOfCell);
            for (var i = 0; i < Globals.HorizontalFieldSize; i++)
            {
                for (var j = 0; j < Globals.VerticalFieldSize; j++)
                {
                    if (_currentField[i, j] == Flags.Apple) DrawRectangleByCoordinates(new Point(i,j), Color.Red, false, true);
                    if(_currentField[i, j] == Flags.Snake) DrawRectangleByCoordinates(new Point(i,j), Color.ForestGreen, true, false);
                    if(_currentField[i, j] == Flags.SnakeHead) DrawRectangleByCoordinates(new Point(i, j), Color.DarkGreen, true, false);
                    if(_currentField[i,j] == Flags.Empty) DrawRectangleByCoordinates(new Point(i,j), Color.White, false, false);
                }
            }
            
        }

        private void DrawRectangleByCoordinates(Point position, Color color, bool isBorderNeeded, bool isEllipse)
        {
            var rectangle = new Rectangle(position.X * Globals.SizeOfCell, position.Y * Globals.SizeOfCell,
                Globals.SizeOfCell, Globals.SizeOfCell);
            Brush brush = new SolidBrush(color);
            using (var graphics = Graphics.FromImage(UpdatedField))
            {
                if (isEllipse)
                {
                    graphics.FillEllipse(brush, rectangle);
                    if (isBorderNeeded) graphics.DrawEllipse(new Pen(Color.Black), rectangle);
                }

                if (isEllipse) return;
                graphics.FillRectangle(brush, rectangle);
                if (isBorderNeeded) graphics.DrawRectangle(new Pen(Color.Black), rectangle);
            }
        }
    }
}