using System.ComponentModel;
using System.Windows.Forms;

namespace Snake
{
    partial class VisualPartOfGame
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentScoreLabel = new System.Windows.Forms.Label();
            this.BestScoreLabel = new System.Windows.Forms.Label();
            this.NicknameInfo = new System.Windows.Forms.Label();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.White;
            this.BackgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundPanel.Controls.Add(this.pictureBox3);
            this.BackgroundPanel.Controls.Add(this.InfoPanel);
            this.BackgroundPanel.Controls.Add(this.UpperPanel);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(673, 697);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(38, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(600, 600);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.CurrentScoreLabel);
            this.InfoPanel.Controls.Add(this.BestScoreLabel);
            this.InfoPanel.Controls.Add(this.NicknameInfo);
            this.InfoPanel.Location = new System.Drawing.Point(37, 35);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(600, 54);
            this.InfoPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(412, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Best:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(228, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current:";
            // 
            // CurrentScoreLabel
            // 
            this.CurrentScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CurrentScoreLabel.Location = new System.Drawing.Point(336, 2);
            this.CurrentScoreLabel.Name = "CurrentScoreLabel";
            this.CurrentScoreLabel.Size = new System.Drawing.Size(70, 48);
            this.CurrentScoreLabel.TabIndex = 3;
            this.CurrentScoreLabel.Text = "0";
            // 
            // BestScoreLabel
            // 
            this.BestScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.BestScoreLabel.Location = new System.Drawing.Point(488, 2);
            this.BestScoreLabel.Name = "BestScoreLabel";
            this.BestScoreLabel.Size = new System.Drawing.Size(67, 48);
            this.BestScoreLabel.TabIndex = 1;
            this.BestScoreLabel.Text = "0";
            // 
            // NicknameInfo
            // 
            this.NicknameInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NicknameInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NicknameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.NicknameInfo.Location = new System.Drawing.Point(-1, -1);
            this.NicknameInfo.Name = "NicknameInfo";
            this.NicknameInfo.Size = new System.Drawing.Size(222, 54);
            this.NicknameInfo.TabIndex = 0;
            this.NicknameInfo.Text = "Nickname";
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.SettingsButton);
            this.UpperPanel.Controls.Add(this.button1);
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(673, 32);
            this.UpperPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(603, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SettingsButton.Location = new System.Drawing.Point(506, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(87, 27);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // VisualPartOfGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(673, 697);
            this.Controls.Add(this.BackgroundPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "VisualPartOfGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualPartOfGame";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VisualPartOfGame_KeyPress);
            this.BackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button SettingsButton;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox3;

        public System.Windows.Forms.PictureBox Snake;

        private System.Windows.Forms.Label CurrentScoreLabel;

        private System.Windows.Forms.Label BestScoreLabel;
        
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Panel UpperPanel;

        private System.Windows.Forms.Panel InfoPanel;

        private System.Windows.Forms.Label NicknameInfo;

        private System.Windows.Forms.Panel BackgroundPanel;

        #endregion
    }
}