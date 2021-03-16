
namespace flappy_bird
{
    partial class mainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlEnd = new System.Windows.Forms.Panel();
            this.pbRetry = new System.Windows.Forms.PictureBox();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblEndScore = new System.Windows.Forms.Label();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.pipeBottom1 = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pnlEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.LightYellow;
            this.lblScore.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScore.Location = new System.Drawing.Point(12, 451);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(111, 36);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pnlEnd
            // 
            this.pnlEnd.BackColor = System.Drawing.Color.Transparent;
            this.pnlEnd.Controls.Add(this.pbRetry);
            this.pnlEnd.Controls.Add(this.pbGameOver);
            this.pnlEnd.Controls.Add(this.lblLives);
            this.pnlEnd.Controls.Add(this.lblEndScore);
            this.pnlEnd.Controls.Add(this.life1);
            this.pnlEnd.Controls.Add(this.life3);
            this.pnlEnd.Controls.Add(this.life2);
            this.pnlEnd.Location = new System.Drawing.Point(-16, -15);
            this.pnlEnd.Name = "pnlEnd";
            this.pnlEnd.Size = new System.Drawing.Size(773, 655);
            this.pnlEnd.TabIndex = 10;
            this.pnlEnd.Visible = false;
            // 
            // pbRetry
            // 
            this.pbRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRetry.Image = global::flappy_bird.Properties.Resources.retry;
            this.pbRetry.Location = new System.Drawing.Point(233, 407);
            this.pbRetry.Name = "pbRetry";
            this.pbRetry.Size = new System.Drawing.Size(226, 56);
            this.pbRetry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRetry.TabIndex = 13;
            this.pbRetry.TabStop = false;
            this.pbRetry.Click += new System.EventHandler(this.pbRetry_Click);
            // 
            // pbGameOver
            // 
            this.pbGameOver.Image = global::flappy_bird.Properties.Resources.game_over;
            this.pbGameOver.Location = new System.Drawing.Point(60, 25);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(602, 112);
            this.pbGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameOver.TabIndex = 12;
            this.pbGameOver.TabStop = false;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(271, 295);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(156, 24);
            this.lblLives.TabIndex = 11;
            this.lblLives.Text = "lives remaining: 3";
            // 
            // lblEndScore
            // 
            this.lblEndScore.AutoSize = true;
            this.lblEndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndScore.Location = new System.Drawing.Point(258, 177);
            this.lblEndScore.Name = "lblEndScore";
            this.lblEndScore.Size = new System.Drawing.Size(119, 31);
            this.lblEndScore.TabIndex = 10;
            this.lblEndScore.Text = "score: 0";
            this.lblEndScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // life1
            // 
            this.life1.BackColor = System.Drawing.Color.Lime;
            this.life1.Image = global::flappy_bird.Properties.Resources.flappy_bird1;
            this.life1.Location = new System.Drawing.Point(255, 322);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(58, 50);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 9;
            this.life1.TabStop = false;
            // 
            // life3
            // 
            this.life3.BackColor = System.Drawing.Color.Lime;
            this.life3.Image = global::flappy_bird.Properties.Resources.flappy_bird1;
            this.life3.Location = new System.Drawing.Point(383, 322);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(58, 50);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 7;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.BackColor = System.Drawing.Color.Lime;
            this.life2.Image = global::flappy_bird.Properties.Resources.flappy_bird1;
            this.life2.Location = new System.Drawing.Point(319, 322);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(58, 50);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 8;
            this.life2.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-51, 412);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1015, 118);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop2.Image")));
            this.pipeTop2.Location = new System.Drawing.Point(117, -120);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(63, 232);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 6;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom2.Image")));
            this.pipeBottom2.Location = new System.Drawing.Point(117, 297);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(63, 261);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 5;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop1
            // 
            this.pipeTop1.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop1.Image")));
            this.pipeTop1.Location = new System.Drawing.Point(534, -120);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(63, 232);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 2;
            this.pipeTop1.TabStop = false;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom1.Image")));
            this.pipeBottom1.Location = new System.Drawing.Point(534, 297);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(63, 261);
            this.pipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom1.TabIndex = 0;
            this.pipeBottom1.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(272, 184);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(58, 50);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(684, 496);
            this.Controls.Add(this.pnlEnd);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.pipeBottom1);
            this.Controls.Add(this.flappyBird);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 535);
            this.MinimumSize = new System.Drawing.Size(700, 535);
            this.Name = "mainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            this.pnlEnd.ResumeLayout(false);
            this.pnlEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeBottom1;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.Panel pnlEnd;
        private System.Windows.Forms.PictureBox pbGameOver;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblEndScore;
        private System.Windows.Forms.PictureBox pbRetry;
    }
}

