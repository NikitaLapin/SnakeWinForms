using System;
using System.Drawing;
using System.Windows.Forms;


namespace Snake
{
    public partial class Form1 : Form
    {
        public bool UserSuccessfullyAuthenticated;
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "") HidingLoginHint.Visible = true;
            else HidingLoginHint.Visible = false;
        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            if(LoginTextBox.Text == String.Empty) HidingLoginHint.Visible = true;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "") HidingPasswordHint.Visible = true;
            else HidingPasswordHint.Visible = false;
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            if(PasswordTextBox.Text == "") HidingPasswordHint.Visible = true;
        }

        private void AcceptAuthorisationButton_Click(object sender, EventArgs e)
        {
            if (DataBase.IsAccountExists(LoginTextBox.Text, PasswordTextBox.Text))
            {
                Program.Nickname = LoginTextBox.Text;
                UserSuccessfullyAuthenticated = true;
                Close();
            }
            else
            {
                SignUpExceptionBox.Text = @"Incorrect login or password";
                SignUpExceptionBox.Show();
            }
        }

        readonly SignUpForm _signUpForm = new SignUpForm();
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                _signUpForm.Visible = true;
            }
            catch (Exception)
            {
                SignUpExceptionBox.Text = @"You have already signed up";
                SignUpExceptionBox.Visible = true;
            }
        }
    }
}