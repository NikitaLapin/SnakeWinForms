using System;
using System.Windows.Forms;
using Snake.AllGame;

namespace Snake
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            label2.Text = Convert.ToString(Globals.Speed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.Speed = Math.Abs(hScrollBar1.Value);
            Hide();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = Convert.ToString(1000 - Math.Abs(hScrollBar1.Value));
        }
    }
}