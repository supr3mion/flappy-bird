
namespace flappy_bird
{
    partial class gameOver
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblHighScoreInfo = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.btnSubmitHighScore = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbNewHighScore = new System.Windows.Forms.PictureBox();
            this.pbCrown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewHighScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrown)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(192, 419);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(295, 31);
            this.tbName.TabIndex = 0;
            // 
            // lblHighScoreInfo
            // 
            this.lblHighScoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreInfo.Location = new System.Drawing.Point(12, 336);
            this.lblHighScoreInfo.Name = "lblHighScoreInfo";
            this.lblHighScoreInfo.Size = new System.Drawing.Size(660, 80);
            this.lblHighScoreInfo.TabIndex = 1;
            this.lblHighScoreInfo.Text = "info";
            this.lblHighScoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(109, 111);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(466, 73);
            this.lblPlayerScore.TabIndex = 2;
            this.lblPlayerScore.Text = "player score";
            this.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmitHighScore
            // 
            this.btnSubmitHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitHighScore.Location = new System.Drawing.Point(262, 456);
            this.btnSubmitHighScore.Name = "btnSubmitHighScore";
            this.btnSubmitHighScore.Size = new System.Drawing.Size(151, 28);
            this.btnSubmitHighScore.TabIndex = 3;
            this.btnSubmitHighScore.Text = "verstuur highscore";
            this.btnSubmitHighScore.UseVisualStyleBackColor = true;
            this.btnSubmitHighScore.Click += new System.EventHandler(this.btnSubmitHighScore_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(262, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "beginscherm";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbNewHighScore
            // 
            this.pbNewHighScore.Image = global::flappy_bird.Properties.Resources.highscore_achieved;
            this.pbNewHighScore.Location = new System.Drawing.Point(109, 163);
            this.pbNewHighScore.Name = "pbNewHighScore";
            this.pbNewHighScore.Size = new System.Drawing.Size(466, 170);
            this.pbNewHighScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewHighScore.TabIndex = 6;
            this.pbNewHighScore.TabStop = false;
            // 
            // pbCrown
            // 
            this.pbCrown.Image = global::flappy_bird.Properties.Resources.crown;
            this.pbCrown.Location = new System.Drawing.Point(290, 45);
            this.pbCrown.Name = "pbCrown";
            this.pbCrown.Size = new System.Drawing.Size(109, 86);
            this.pbCrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrown.TabIndex = 4;
            this.pbCrown.TabStop = false;
            // 
            // gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(684, 496);
            this.Controls.Add(this.pbNewHighScore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbCrown);
            this.Controls.Add(this.btnSubmitHighScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblHighScoreInfo);
            this.Controls.Add(this.tbName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 535);
            this.MinimumSize = new System.Drawing.Size(700, 535);
            this.Name = "gameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gameOver";
            ((System.ComponentModel.ISupportInitialize)(this.pbNewHighScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblHighScoreInfo;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Button btnSubmitHighScore;
        private System.Windows.Forms.PictureBox pbCrown;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbNewHighScore;
    }
}