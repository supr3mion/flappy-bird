
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
            this.highscore2 = new System.Windows.Forms.Label();
            this.highscore3 = new System.Windows.Forms.Label();
            this.highscore1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.SuspendLayout();
            // 
            // highscore2
            // 
            this.highscore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore2.Location = new System.Drawing.Point(18, 232);
            this.highscore2.Name = "highscore2";
            this.highscore2.Size = new System.Drawing.Size(230, 66);
            this.highscore2.TabIndex = 9;
            this.highscore2.Text = "[naam]\r\n[score]";
            this.highscore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscore3
            // 
            this.highscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore3.Location = new System.Drawing.Point(442, 263);
            this.highscore3.Name = "highscore3";
            this.highscore3.Size = new System.Drawing.Size(236, 66);
            this.highscore3.TabIndex = 8;
            this.highscore3.Text = "[naam]\r\n[score]";
            this.highscore3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscore1
            // 
            this.highscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore1.Location = new System.Drawing.Point(181, 166);
            this.highscore1.Name = "highscore1";
            this.highscore1.Size = new System.Drawing.Size(329, 66);
            this.highscore1.TabIndex = 6;
            this.highscore1.Text = "[naam]\r\n[score]";
            this.highscore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            // highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(684, 496);
            this.Controls.Add(this.home);
            this.Controls.Add(this.highscore2);
            this.Controls.Add(this.highscore3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.highscore1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 535);
            this.MinimumSize = new System.Drawing.Size(700, 535);
            this.Name = "highscore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "higscore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label highscore2;
        private System.Windows.Forms.Label highscore3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label highscore1;
        private System.Windows.Forms.PictureBox home;
    }
}