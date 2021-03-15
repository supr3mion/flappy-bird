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

        public mainScreen()
        {
            InitializeComponent();
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

            if (pipeBottom1.Left < -150)
            {
                int randomNumberLeft = number.Next(700, 800);
                int randomNumberTop = number.Next(250, 400);
                pipeBottom1.Left = randomNumberLeft;
                pipeBottom1.Top = randomNumberTop;

                score++;
            }
            if (pipeTop1.Left < -150)
            {
                int randomNumberLeft = number.Next(700, 800);
                int randomNumberTop = number.Next(-190, -70);
                pipeTop1.Left = randomNumberLeft;
                pipeTop1.Top = randomNumberTop;
            }
            if (pipeBottom2.Left < -150)
            {
                int randomNumberLeft = number.Next(700, 800);
                int randomNumberTop = number.Next(250, 400);
                pipeBottom2.Left = randomNumberLeft;
                pipeBottom2.Top = randomNumberTop;
                score++;
            }
            if (pipeTop2.Left < -150)
            {
                int randomNumberLeft = number.Next(700, 800);
                int randomNumberTop = number.Next(-190, -70);
                pipeTop2.Left = randomNumberLeft;
                pipeTop2.Top = randomNumberTop;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom1.Bounds) || 
                flappyBird.Bounds.IntersectsWith(pipeTop1.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                lives = lives - 1;
                endGame();
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
            lblScore.Text += "  Game Over!!!";
        }
    }
}
