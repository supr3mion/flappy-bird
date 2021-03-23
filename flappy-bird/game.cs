using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class mainScreen : Form
    {

        int pipeSpeed = 10;
        int gravity = 10;
        int score = 0;
        int scoreStage = 5;
        int lives = 3;
        int endScore = 0;

        public mainScreen()
        {
            InitializeComponent();
            pipeBottom1.Hide();
            pipeBottom2.Hide();
            pipeTop1.Hide();
            pipeTop2.Hide();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom1.Left -= pipeSpeed;
            pipeTop1.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;

            lblScore.Text = "score: " + score.ToString();

            var number = new Random();

            if (pipeTop1.Left < -150)
            {
                //voor de onderste buis
                int randomLeft1 = number.Next(650, 800);
                int randomTop1 = number.Next(250, 400);

                //voor de bovenste buis
                //int randomLeft2 = number.Next(600, 800);
                int randomTop2 = number.Next(-190, -70);

                int space1 = randomTop1 - 261;
                int space2 = randomTop2 + 232;
                int totalSpace = space2 - space1;

                if ((totalSpace < 0) == true)
                {
                    //onderste buis
                    pipeBottom1.Left = randomLeft1;
                    pipeBottom1.Top = 275;

                    //bovernste buis
                    pipeTop1.Left = 750;
                    pipeTop1.Top = -130;
                } 
                if ((totalSpace < 0) == false)
                {
                    //onderste buis
                    pipeBottom1.Left = randomLeft1;
                    pipeBottom1.Top = randomTop1;

                    //onderste buis
                    pipeTop1.Left = 750;
                    pipeTop1.Top = randomTop2;
                }
                if (pipeTop1.Visible != true)
                {
                    pipeTop1.Show();
                    pipeBottom1.Show();
                } else
                {
                    score++;
                }

            }

            if (pipeTop2.Left < -150)
            {
                //voor de onderste buis
                int randomLeft1= number.Next(650, 800);
                int randomTop1 = number.Next(250, 400);

                //voor de bovenste buis
                //int randomLeft2 = number.Next(600, 800);
                int randomTop2 = number.Next(-190, -70);

                int space1 = randomTop1 - 261;
                int space2 = randomTop2 + 232;
                int totalSpace = space2 - space1;

                if ((totalSpace < 0) == true)
                {
                    //onderste buis
                    pipeBottom2.Left = randomLeft1;
                    pipeBottom2.Top = 275;

                    //bovernste buis
                    pipeTop2.Left = 750;
                    pipeTop2.Top = -130;
                } 
                if ((totalSpace < 0) == false)
                {
                    //onderste buis
                    pipeBottom2.Left = randomLeft1;
                    pipeBottom2.Top = randomTop1;

                    //onderste buis
                    pipeTop2.Left = 750;
                    pipeTop2.Top = randomTop2;
                }
                if (pipeTop2.Visible != true)
                {
                    pipeTop2.Show();
                    pipeBottom2.Show();
                } else
                {
                    score++;
                }
                
            }

                if (pipeTop1.Visible && pipeBottom1.Visible == true)
            {
                if (flappyBird.Bounds.IntersectsWith(pipeBottom1.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop1.Bounds)
                )
                {
                    lives = lives - 1;
                    endGame();
                }
            }
            if (pipeTop2.Visible && pipeBottom2.Visible == true)
            {
                if (flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds)
                )
                {
                    lives = lives - 1;
                    endGame();
                }
            }
            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                lives = lives - 1;
                endGame();
            }


            if (lives == 2)
            {
                this.life3.BackColor = System.Drawing.Color.Red;
                lblLives.Text = "lives remaining: 2";
            }
            if (lives == 1)
            {
                this.life2.BackColor = System.Drawing.Color.Red;
                lblLives.Text = "lives remaining: 1";
            }
            if (lives == 0)
            {
                finalScreen();
            }


            if (score == scoreStage)
            {
                pipeSpeed = pipeSpeed + 1;
                scoreStage = scoreStage + 5; 
                
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
            if (e.KeyCode == Keys.Enter && pbRetry.Visible == true)
            {
                reset();
            }

        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.Space) 
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            pnlEnd.Show();
            endScore = endScore + score;
            if (lives == 0)
            {
                lblEndScore.Text = "end score: " + endScore.ToString();
            } else
            {
                lblEndScore.Text = "current score: " + endScore.ToString();
            }
            
        }

        private void reset()
        {

            score = 0;

            pipeSpeed = 10;

            scoreStage = 5;

            pipeBottom1.Hide();
            pipeBottom2.Hide();
            pipeTop1.Hide();
            pipeTop2.Hide();

            pipeBottom1.Left = 534;
            pipeBottom1.Top = 297;

            pipeTop1.Left = 534;
            pipeTop1.Top = -130;

            pipeBottom2.Left = 117;
            pipeBottom2.Top = 297;

            pipeTop2.Left = 117;
            pipeTop2.Top = -130;

            flappyBird.Left = 272;
            flappyBird.Top = 184;

            gameTimer.Start();

            pnlEnd.Hide();

        }

        private void pbRetry_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void finalScreen()
        {
            this.life1.BackColor = System.Drawing.Color.Red;
            lblLives.Text = "lives remaining: 0";
            pbRetry.Hide();
            retryInfo.Hide();
            int totalScore = endScore;

            this.Hide();

            loading loadingScreen = new loading("results");
            loadingScreen.Show();

            gameOver gameOverForm = new gameOver(totalScore);
            gameOverForm.ShowDialog();

            loadingScreen.Close();

            Close();
        }

    }
}
