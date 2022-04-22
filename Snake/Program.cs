using System;
using System.Windows.Forms;

namespace Snake
{
    static class Program
    {
        public static string Nickname;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginForm = new Form1();
            Application.Run(loginForm);
            if (!loginForm.UserSuccessfullyAuthenticated) return;
            var snakeForm = new VisualPartOfGame();
            Application.Run(snakeForm);
        }
    }
}