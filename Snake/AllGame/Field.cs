using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Snake.AllGame
{
    public class Field : IField
    {
        public Snake Snake;
        public Apple Apple;
        private Update _update = new Update(Direction.Directions.Stop, false);
        public readonly VisualController VisualController = new VisualController();
        private readonly SoundPlayer _mainThemePlayer = new SoundPlayer("C:/Users/nikla/RiderProjects/SoundTest/SoundTest/Sounds/MainTheme.wav");
        private readonly SoundPlayer _losePlayer = new SoundPlayer("C:/Users/nikla/RiderProjects/SoundTest/SoundTest/Sounds/DeathSound.wav");

        public void SetUp()
        {
            VisualController.MakeFieldEmpty();
            Snake = new Snake();
            VisualController.AddSnakeHead();
            Apple = new Apple(0);
            Apple.GenerateApple(Snake);
            VisualController.AddApple(Apple.CurrentPosition);
        }

        public void NewUpdate(KeyPressEventArgs e)
        {
            Direction.Directions newDirection = Direction.Directions.Stop;
            Direction.ConvertKeyToDirection(e.KeyChar, ref newDirection);
            _update = new Update(newDirection, true);
            _update.IsUpdated = true;
        }

        public void Move()
        {
            while (VisualPartOfGame.IsAlive)
            {
                _mainThemePlayer.PlayLooping();
                while (Snake.SnakeHead.CurrentDirection != Direction.Directions.Stop)
                {
                    if (_update.IsUpdated) CheckForUpdate();
                    Snake.Move(Snake.SnakeHead.CurrentDirection);
                    TryEatApple();
                    CheckIfCrashed();
                    if (_update.IsUpdated) CheckForUpdate();
                    if (Snake.SnakeHead.CurrentDirection == Direction.Directions.Stop)
                    {
                        _mainThemePlayer.Stop();
                        _losePlayer.PlaySync();
                        break;
                    }
                    VisualController.MakeFieldEmpty();
                    VisualController.AddSnake(Snake.SnakeHead);
                    VisualController.MakeFirstAHead(Snake.SnakeHead);
                    VisualController.AddApple(Apple.CurrentPosition);
                    VisualController.CorrectBitmap();
                    if (_update.IsUpdated) CheckForUpdate();
                    Thread.Sleep(Globals.Speed);
                }
                _mainThemePlayer.Stop();
                Apple.ItsNumber = 2;
                Snake.SnakeHead.NextBody = null;
                Snake.SnakeHead.CurrentPosition =
                    new Point((Globals.HorizontalFieldSize - 1) / 2, (Globals.VerticalFieldSize - 1) / 2);
                VisualController.MakeFieldEmpty();
                VisualController.AddSnakeHead();
                VisualController.AddApple(Apple.CurrentPosition);
                
                while (Snake.SnakeHead.CurrentDirection == Direction.Directions.Stop)
                {
                    CheckForUpdate();
                    VisualController.CorrectBitmap();
                    Thread.Sleep(Globals.Speed);
                }
            }
        }

        private void CheckForUpdate()
        {
            if (_update.IsUpdated) Snake.SnakeHead.CurrentDirection = _update.NewDirection;
            _update.IsUpdated = false;
        }
        private bool IsEatingApple()
        {
            return Snake.SnakeHead.CurrentPosition == Apple.CurrentPosition;
        }
        private void EatApple()
        {
            Snake.AddNewBody();
            VisualController.DeleteApple(Apple.CurrentPosition);
            Apple.GenerateApple(Snake);
        }
        private void TryEatApple()
        {
            if (IsEatingApple()) EatApple();
        }

        private void CheckIfCrashed()
        {
            var head = Snake.SnakeHead.CurrentPosition;
            if (head.X < 0 || head.Y < 0 || head.X > Globals.HorizontalFieldSize-1 || head.Y > Globals.VerticalFieldSize-1)
                _update = new Update(Direction.Directions.Stop, true);
            if (Snake.SnakeHead.NextBody != null)
            {
                if (Snake.SnakeHead.NextBody.isOnHead(Snake.SnakeHead.CurrentPosition))
                    _update = new Update(Direction.Directions.Stop, true);
            }
        }
    }
}