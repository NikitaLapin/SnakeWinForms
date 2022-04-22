using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.IncorrectInputHint = new System.Windows.Forms.TextBox();
            this.RepasswordHint = new System.Windows.Forms.TextBox();
            this.PasswordHint = new System.Windows.Forms.TextBox();
            this.LoginHint = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PasswordPicture = new System.Windows.Forms.PictureBox();
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.RepasswordBox = new System.Windows.Forms.TextBox();
            this.AgeCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.PasswordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.LoginPicture)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.White;
            this.BackgroundPanel.BackgroundImage = global::Snake.Properties.Resources.BackgroundSnakeIcon2;
            this.BackgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackgroundPanel.Controls.Add(this.IncorrectInputHint);
            this.BackgroundPanel.Controls.Add(this.RepasswordHint);
            this.BackgroundPanel.Controls.Add(this.PasswordHint);
            this.BackgroundPanel.Controls.Add(this.LoginHint);
            this.BackgroundPanel.Controls.Add(this.pictureBox3);
            this.BackgroundPanel.Controls.Add(this.PasswordPicture);
            this.BackgroundPanel.Controls.Add(this.LoginPicture);
            this.BackgroundPanel.Controls.Add(this.RepasswordBox);
            this.BackgroundPanel.Controls.Add(this.AgeCheckBox);
            this.BackgroundPanel.Controls.Add(this.ConfirmButton);
            this.BackgroundPanel.Controls.Add(this.CancelButton);
            this.BackgroundPanel.Controls.Add(this.PasswordBox);
            this.BackgroundPanel.Controls.Add(this.LoginBox);
            this.BackgroundPanel.Controls.Add(this.Title);
            this.BackgroundPanel.Controls.Add(this.UpperPanel);
            this.BackgroundPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(352, 491);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // IncorrectInputHint
            // 
            this.IncorrectInputHint.BackColor = System.Drawing.Color.White;
            this.IncorrectInputHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncorrectInputHint.Enabled = false;
            this.IncorrectInputHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.IncorrectInputHint.ForeColor = System.Drawing.Color.Red;
            this.IncorrectInputHint.Location = new System.Drawing.Point(56, 369);
            this.IncorrectInputHint.Multiline = true;
            this.IncorrectInputHint.Name = "IncorrectInputHint";
            this.IncorrectInputHint.Size = new System.Drawing.Size(259, 48);
            this.IncorrectInputHint.TabIndex = 14;
            // 
            // RepasswordHint
            // 
            this.RepasswordHint.BackColor = System.Drawing.Color.White;
            this.RepasswordHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RepasswordHint.Enabled = false;
            this.RepasswordHint.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RepasswordHint.Location = new System.Drawing.Point(97, 247);
            this.RepasswordHint.Name = "RepasswordHint";
            this.RepasswordHint.Size = new System.Drawing.Size(218, 39);
            this.RepasswordHint.TabIndex = 13;
            this.RepasswordHint.Text = "Confirm password";
            // 
            // PasswordHint
            // 
            this.PasswordHint.BackColor = System.Drawing.Color.White;
            this.PasswordHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordHint.Enabled = false;
            this.PasswordHint.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.PasswordHint.Location = new System.Drawing.Point(97, 170);
            this.PasswordHint.Name = "PasswordHint";
            this.PasswordHint.Size = new System.Drawing.Size(238, 39);
            this.PasswordHint.TabIndex = 12;
            this.PasswordHint.Text = "Enter your password";
            // 
            // LoginHint
            // 
            this.LoginHint.BackColor = System.Drawing.Color.White;
            this.LoginHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginHint.Enabled = false;
            this.LoginHint.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LoginHint.Location = new System.Drawing.Point(97, 90);
            this.LoginHint.MaxLength = 32000;
            this.LoginHint.Name = "LoginHint";
            this.LoginHint.Size = new System.Drawing.Size(240, 39);
            this.LoginHint.TabIndex = 11;
            this.LoginHint.Text = "Enter new login here";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = global::Snake.Properties.Resources.change_password;
            this.pictureBox3.Image = global::Snake.Properties.Resources.change_password;
            this.pictureBox3.InitialImage = global::Snake.Properties.Resources.change_password;
            this.pictureBox3.Location = new System.Drawing.Point(34, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // PasswordPicture
            // 
            this.PasswordPicture.ErrorImage = global::Snake.Properties.Resources.png_transparent_password_manager_computer_icons_password_strength_password_safe_chang_miscellaneous_password_strength_password_safe_thumbnail;
            this.PasswordPicture.Image = global::Snake.Properties.Resources._102643;
            this.PasswordPicture.InitialImage = global::Snake.Properties.Resources.png_transparent_password_manager_computer_icons_password_strength_password_safe_chang_miscellaneous_password_strength_password_safe_thumbnail;
            this.PasswordPicture.Location = new System.Drawing.Point(27, 166);
            this.PasswordPicture.Name = "PasswordPicture";
            this.PasswordPicture.Size = new System.Drawing.Size(60, 51);
            this.PasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordPicture.TabIndex = 9;
            this.PasswordPicture.TabStop = false;
            // 
            // LoginPicture
            // 
            this.LoginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginPicture.ErrorImage = global::Snake.Properties.Resources.Sample_User_Icon;
            this.LoginPicture.Image = global::Snake.Properties.Resources.Sample_User_Icon;
            this.LoginPicture.InitialImage = global::Snake.Properties.Resources.Sample_User_Icon;
            this.LoginPicture.Location = new System.Drawing.Point(34, 86);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(51, 51);
            this.LoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPicture.TabIndex = 8;
            this.LoginPicture.TabStop = false;
            // 
            // RepasswordBox
            // 
            this.RepasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepasswordBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RepasswordBox.Location = new System.Drawing.Point(91, 242);
            this.RepasswordBox.MaxLength = 20;
            this.RepasswordBox.Name = "RepasswordBox";
            this.RepasswordBox.Size = new System.Drawing.Size(249, 50);
            this.RepasswordBox.TabIndex = 7;
            this.RepasswordBox.UseSystemPasswordChar = true;
            this.RepasswordBox.TextChanged += new System.EventHandler(this.RepasswordBox_TextChanged);
            // 
            // AgeCheckBox
            // 
            this.AgeCheckBox.BackColor = System.Drawing.Color.White;
            this.AgeCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AgeCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.AgeCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.AgeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AgeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AgeCheckBox.Location = new System.Drawing.Point(194, 299);
            this.AgeCheckBox.Name = "AgeCheckBox";
            this.AgeCheckBox.Size = new System.Drawing.Size(146, 36);
            this.AgeCheckBox.TabIndex = 6;
            this.AgeCheckBox.Text = "Show password";
            this.AgeCheckBox.UseVisualStyleBackColor = false;
            this.AgeCheckBox.CheckedChanged += new System.EventHandler(this.AgeCheckBox_CheckedChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(194, 423);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(129, 39);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Brown;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(34, 423);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(122, 39);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.PasswordBox.Location = new System.Drawing.Point(91, 166);
            this.PasswordBox.MaxLength = 20;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(249, 50);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // LoginBox
            // 
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginBox.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LoginBox.Location = new System.Drawing.Point(91, 86);
            this.LoginBox.MaxLength = 15;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(249, 50);
            this.LoginBox.TabIndex = 2;
            this.LoginBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Title.Location = new System.Drawing.Point(104, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(150, 51);
            this.Title.TabIndex = 1;
            this.Title.Text = "Sign Up";
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.LightGray;
            this.UpperPanel.Controls.Add(this.CloseButton);
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(352, 29);
            this.UpperPanel.TabIndex = 0;
            this.UpperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseDown);
            this.UpperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Firebrick;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(292, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(57, 24);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 491);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1500, 500);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SignUpForm";
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.PasswordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.LoginPicture)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox IncorrectInputHint;
        private System.Windows.Forms.TextBox RepasswordHint;
        private System.Windows.Forms.TextBox PasswordHint;
        private System.Windows.Forms.TextBox LoginHint;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox PasswordPicture;
        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.TextBox PasswordBox;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.CheckBox AgeCheckBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox RepasswordBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel BackgroundPanel;
        #endregion
    }
}