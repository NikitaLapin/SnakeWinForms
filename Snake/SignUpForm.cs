using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Snake
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private Point _lastPoint;
        private void UpperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button & MouseButtons.Left) != 0)
            {
                this.Left += e.X - _lastPoint.X;
                this.Top += e.Y - _lastPoint.Y;
            }
        }

        private void UpperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _lastPoint = new Point(e.X, e.Y);
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginBox.Text != "") LoginHint.Hide();
            else LoginHint.Show();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if(PasswordBox.Text != "") PasswordHint.Hide();
            else PasswordHint.Show();
        }

        private void RepasswordBox_TextChanged(object sender, EventArgs e)
        {
            if(RepasswordBox.Text != "") RepasswordHint.Hide();
            else RepasswordHint.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            bool isNewLogin = DataBase.IsNewLogin(LoginBox.Text);
            if (PasswordBox.Text == RepasswordBox.Text && PasswordBox.Text != "" && PasswordBox.Text.Length >= 8 &&
                LoginBox.Text.Length >= 6 && isNewLogin)
            {
                DataBase.CreateNewAccount(LoginBox.Text, PasswordBox.Text);
                Close();
            }
            else if (LoginBox.Text.Length < 6) IncorrectInputHint.Text = "Login length must be more than 6 symbols";
            else if (!isNewLogin) IncorrectInputHint.Text = "Login already exists";
            else if (PasswordBox.Text.Length < 8) IncorrectInputHint.Text = "Password length must be more than 8 symbols";
            else if (PasswordBox.Text != RepasswordBox.Text) IncorrectInputHint.Text = "Password and confirmation password must be same";
        }

        private void AgeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AgeCheckBox.Checked)
            {
                RepasswordBox.UseSystemPasswordChar = false;
                PasswordBox.UseSystemPasswordChar = false;
            }
            else
            {
                RepasswordBox.UseSystemPasswordChar = true;
                PasswordBox.UseSystemPasswordChar = true;
            }
        }
    }
}