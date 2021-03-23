
namespace flappy_bird
{
    partial class highscore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(highscore));
            this.home = new System.Windows.Forms.PictureBox();
            this.lvHighScores = new System.Windows.Forms.ListView();
            this.playerPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(12, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(117, 44);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home.TabIndex = 10;
            this.home.TabStop = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // lvHighScores
            // 
            this.lvHighScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerPlace,
            this.playerName,
            this.playerScore});
            this.lvHighScores.HideSelection = false;
            this.lvHighScores.Location = new System.Drawing.Point(192, 73);
            this.lvHighScores.Name = "lvHighScores";
            this.lvHighScores.Size = new System.Drawing.Size(320, 362);
            this.lvHighScores.TabIndex = 11;
            this.lvHighScores.UseCompatibleStateImageBehavior = false;
            this.lvHighScores.View = System.Windows.Forms.View.Details;
            // 
            // playerPlace
            // 
            this.playerPlace.Text = "plaats";
            // 
            // playerName
            // 
            this.playerName.Text = "naam speler";
            this.playerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerName.Width = 154;
            // 
            // playerScore
            // 
            this.playerScore.Text = "score";
            this.playerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerScore.Width = 100;
            // 
            // highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(684, 496);
            this.Controls.Add(this.lvHighScores);
            this.Controls.Add(this.home);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 535);
            this.MinimumSize = new System.Drawing.Size(700, 535);
            this.Name = "highscore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "higscore";
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.ListView lvHighScores;
        private System.Windows.Forms.ColumnHeader playerPlace;
        private System.Windows.Forms.ColumnHeader playerName;
        private System.Windows.Forms.ColumnHeader playerScore;
    }
}