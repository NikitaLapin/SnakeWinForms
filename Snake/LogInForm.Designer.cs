using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.SignUpExceptionBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.AcceptAuthorisationButton = new System.Windows.Forms.Button();
            this.AuthorisationTitle = new System.Windows.Forms.Label();
            this.HidingPasswordHint = new System.Windows.Forms.TextBox();
            this.HidingLoginHint = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordImage = new System.Windows.Forms.PictureBox();
            this.LoginImage = new System.Windows.Forms.PictureBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.PasswordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.LoginImage)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.White;
            this.BackgroundPanel.BackgroundImage = global::Snake.Properties.Resources.SnakeBackground;
            this.BackgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundPanel.Controls.Add(this.SignUpExceptionBox);
            this.BackgroundPanel.Controls.Add(this.SignUpButton);
            this.BackgroundPanel.Controls.Add(this.AcceptAuthorisationButton);
            this.BackgroundPanel.Controls.Add(this.AuthorisationTitle);
            this.BackgroundPanel.Controls.Add(this.HidingPasswordHint);
            this.BackgroundPanel.Controls.Add(this.HidingLoginHint);
            this.BackgroundPanel.Controls.Add(this.PasswordTextBox);
            this.BackgroundPanel.Controls.Add(this.PasswordImage);
            this.BackgroundPanel.Controls.Add(this.LoginImage);
            this.BackgroundPanel.Controls.Add(this.LoginTextBox);
            this.BackgroundPanel.Controls.Add(this.UpperPanel);
            this.BackgroundPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(435, 608);
            this.BackgroundPanel.TabIndex = 1;
            // 
            // SignUpExceptionBox
            // 
            this.SignUpExceptionBox.BackColor = System.Drawing.Color.White;
            this.SignUpExceptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignUpExceptionBox.ForeColor = System.Drawing.Color.Red;
            this.SignUpExceptionBox.Location = new System.Drawing.Point(41, 485);
            this.SignUpExceptionBox.Multiline = true;
            this.SignUpExceptionBox.Name = "SignUpExceptionBox";
            this.SignUpExceptionBox.Size = new System.Drawing.Size(154, 23);
            this.SignUpExceptionBox.TabIndex = 11;
            this.SignUpExceptionBox.Text = "You\'ve already created account";
            this.SignUpExceptionBox.Visible = false;
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Brown;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SignUpButton.Location = new System.Drawing.Point(41, 514);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(154, 58);
            this.SignUpButton.TabIndex = 10;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // AcceptAuthorisationButton
            // 
            this.AcceptAuthorisationButton.BackColor = System.Drawing.Color.ForestGreen;
            this.AcceptAuthorisationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptAuthorisationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AcceptAuthorisationButton.Location = new System.Drawing.Point(231, 514);
            this.AcceptAuthorisationButton.Name = "AcceptAuthorisationButton";
            this.AcceptAuthorisationButton.Size = new System.Drawing.Size(154, 58);
            this.AcceptAuthorisationButton.TabIndex = 9;
            this.AcceptAuthorisationButton.Text = "Log In";
            this.AcceptAuthorisationButton.UseVisualStyleBackColor = false;
            this.AcceptAuthorisationButton.Click += new System.EventHandler(this.AcceptAuthorisationButton_Click);
            // 
            // AuthorisationTitle
            // 
            this.AuthorisationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AuthorisationTitle.Location = new System.Drawing.Point(41, 46);
            this.AuthorisationTitle.Name = "AuthorisationTitle";
            this.AuthorisationTitle.Size = new System.Drawing.Size(364, 62);
            this.AuthorisationTitle.TabIndex = 7;
            this.AuthorisationTitle.Text = "Leaderboard Log In";
            // 
            // HidingPasswordHint
            // 
            this.HidingPasswordHint.BackColor = System.Drawing.Color.White;
            this.HidingPasswordHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HidingPasswordHint.Enabled = false;
            this.HidingPasswordHint.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.HidingPasswordHint.Location = new System.Drawing.Point(102, 277);
            this.HidingPasswordHint.Name = "HidingPasswordHint";
            this.HidingPasswordHint.ReadOnly = true;
            this.HidingPasswordHint.Size = new System.Drawing.Size(283, 39);
            this.HidingPasswordHint.TabIndex = 6;
            this.HidingPasswordHint.Text = "Enter your password";
            // 
            // HidingLoginHint
            // 
            this.HidingLoginHint.BackColor = System.Drawing.Color.White;
            this.HidingLoginHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HidingLoginHint.Enabled = false;
            this.HidingLoginHint.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.HidingLoginHint.Location = new System.Drawing.Point(102, 197);
            this.HidingLoginHint.Name = "HidingLoginHint";
            this.HidingLoginHint.ReadOnly = true;
            this.HidingLoginHint.Size = new System.Drawing.Size(283, 39);
            this.HidingLoginHint.TabIndex = 5;
            this.HidingLoginHint.Text = "Enter your nickname";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(87, 268);
            this.PasswordTextBox.MaxLength = 15;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(336, 50);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // PasswordImage
            // 
            this.PasswordImage.ErrorImage = global::Snake.Properties.Resources.change_password;
            this.PasswordImage.Image = global::Snake.Properties.Resources.change_password;
            this.PasswordImage.InitialImage = global::Snake.Properties.Resources.change_password;
            this.PasswordImage.Location = new System.Drawing.Point(30, 268);
            this.PasswordImage.Name = "PasswordImage";
            this.PasswordImage.Size = new System.Drawing.Size(50, 50);
            this.PasswordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordImage.TabIndex = 4;
            this.PasswordImage.TabStop = false;
            // 
            // LoginImage
            // 
            this.LoginImage.ErrorImage = global::Snake.Properties.Resources.Sample_User_Icon;
            this.LoginImage.Image = global::Snake.Properties.Resources.Sample_User_Icon;
            this.LoginImage.InitialImage = global::Snake.Properties.Resources.Sample_User_Icon;
            this.LoginImage.Location = new System.Drawing.Point(25, 183);
            this.LoginImage.Name = "LoginImage";
            this.LoginImage.Size = new System.Drawing.Size(55, 55);
            this.LoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginImage.TabIndex = 3;
            this.LoginImage.TabStop = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LoginTextBox.Location = new System.Drawing.Point(87, 188);
            this.LoginTextBox.MaxLength = 15;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(336, 50);
            this.LoginTextBox.TabIndex = 2;
            this.LoginTextBox.Click += new System.EventHandler(this.LoginTextBox_Click);
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.LightGray;
            this.UpperPanel.Controls.Add(this.CloseButton);
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(435, 29);
            this.UpperPanel.TabIndex = 1;
            this.UpperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseDown);
            this.UpperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Firebrick;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(382, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 22);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 608);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1000, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.PasswordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.LoginImage)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox SignUpExceptionBox;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button AcceptAuthorisationButton;
        private System.Windows.Forms.Label AuthorisationTitle;
        private System.Windows.Forms.TextBox HidingPasswordHint;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox HidingLoginHint;
        private System.Windows.Forms.PictureBox PasswordImage;
        private System.Windows.Forms.PictureBox LoginImage;
        public System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel BackgroundPanel;

        #endregion
    }
}