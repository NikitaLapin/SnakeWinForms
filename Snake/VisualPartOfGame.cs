using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Snake.AllGame;

namespace Snake
{
    public partial class VisualPartOfGame : Form
    {
        private readonly Field _field = new Field();
        private readonly SettingsForm _settings = new SettingsForm();
        public static bool IsAlive = true;
        public VisualPartOfGame()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon("C:/Users/nikla/RiderProjects/Snake/Snake/Resources/BackgroundSnakeIcon2.jpg");
            NicknameInfo.Text = Program.Nickname;
            BestScoreLabel.Text = DataBase.GetBestScore(NicknameInfo.Text);
            _field.SetUp();
            var controlBitmap = new Thread(ControlBitmap);
            var threadGame = new Thread(_field.Move);
            controlBitmap.Start();
            threadGame.Start();
            _field.Snake.SnakeHead.CurrentDirection = Direction.Directions.Stop;
        }

        private void VisualPartOfGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            Direction.Directions newDirection = Direction.Directions.Stop;
            if (Direction.ConvertKeyToDirection(e.KeyChar, ref newDirection) &&
                Direction.IsAbleToTurn(_field.Snake.SnakeHead.CurrentDirection, newDirection)) _field.NewUpdate(e);
        }

        private void ControlBitmap()
        {
            while (IsAlive)
            {
                pictureBox3.BackgroundImage = _field.VisualController.UpdatedField;
                if (int.Parse(BestScoreLabel.Text) < int.Parse(CurrentScoreLabel.Text))
                    DataBase.NewBestScore(NicknameInfo.Text, int.Parse(CurrentScoreLabel.Text));
                CurrentScoreLabel.Text = Convert.ToString(_field.Apple.ItsNumber-1);
                BestScoreLabel.Text = DataBase.GetBestScore(NicknameInfo.Text);
                Thread.Sleep(Globals.Speed/10);
            }
            
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsAlive = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if(!_settings.Visible) _settings.Show();
            else _settings.Hide();
        }
    }
}