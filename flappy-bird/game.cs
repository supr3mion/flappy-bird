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
        //start waarden worden ingestelt

        int pipeSpeed = 10;
        int gravity = 10;
        int score = 0;
        int scoreStage = 5;
        int lives = 3;
        int endScore = 0;

        public mainScreen()
        {
            //tijdens start programma worden de buizen verborgen om dierecte crash te voorkomen
            InitializeComponent();
            pipeBottom1.Hide();
            pipeBottom2.Hide();
            pipeTop1.Hide();
            pipeTop2.Hide();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            //bewegingen worden ingestelt
            flappyBird.Top += gravity;
            pipeBottom1.Left -= pipeSpeed;
            pipeTop1.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;

            //de op datmomet behaalde score word zichtbaar gemaakt
            lblScore.Text = "score: " + score.ToString();

            //systeem gekozen nummer systeem word hiet gemaakt
            var number = new Random();

            //kijken als de 1ste bovenste buis deze locatie al voorbij is
            if (pipeTop1.Left < -150)
            {
                //in de volgende 2 onderdelen kiest het systeem een gatal tussen de 2 gegeven getallen

                //voor de onderste buis
                int randomLeft1 = number.Next(650, 800);
                int randomTop1 = number.Next(250, 400);

                //voor de bovenste buis
                int randomTop2 = number.Next(-190, -70);

                //hier word gekeken als de posieties onmogelijuk zijn voor de speler
                //dit werkt 9 van de 10 keer zo ongeveer
                int space1 = randomTop1 - 261;
                int space2 = randomTop2 + 232;
                int totalSpace = space2 - space1;

                //als de posities onmogelijk zijn dan word het volgende geactiveerd
                if ((totalSpace < 0) == true)
                {
                    //omdat de systeem waarden onmogelijk waren voor de speler worden en vaste waarden voor de hoogtes van de pijpen gegeven

                    //onderste buis
                    pipeBottom1.Left = randomLeft1;
                    pipeBottom1.Top = 275;

                    //bovernste buis
                    pipeTop1.Left = 750;
                    pipeTop1.Top = -130;
                } 
                //als de systeem waarden mogeljik zijn voor de speler dan word het volgende uitgevoerd
                if ((totalSpace < 0) == false)
                {
                    //hier worden de systeem gekozen waarden gegeven aan de buis

                    //onderste buis
                    pipeBottom1.Left = randomLeft1;
                    pipeBottom1.Top = randomTop1;

                    //onderste buis
                    pipeTop1.Left = 750;
                    pipeTop1.Top = randomTop2;
                }
                //hier word gekeken als de buizen verborgen zijn
                if (pipeTop1.Visible != true)
                {
                    //als ze verborgen waren dan worden ze hieronder zichtbaar gemaakt
                    pipeTop1.Show();
                    pipeBottom1.Show();
                } else
                {
                    //als de buizen wel zightbaar waren dan word er +1 score gedaan voor de speler
                    score++;
                }

            }

            //hieronder word op de zelfde manier de andere set buizen berekent

            if (pipeTop2.Left < -150)
            {
                //voor de onderste buis
                int randomLeft1= number.Next(650, 800);
                int randomTop1 = number.Next(250, 400);

                //voor de bovenste buis
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

            //in de volgende onderdelen word gekeken als de speler af is en er word een leven ontnomen van de 3 levens

            //hier word gekeken als de buizen zichbaar zijn of niet
            if (pipeTop1.Visible == true && pipeBottom1.Visible == true)
            {
                //als ze zichtbaar zijn dan word er gekeken als ze in contact comen met 1 van de volgende elementen
                if (flappyBird.Bounds.IntersectsWith(pipeBottom1.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop1.Bounds)
                )
                {
                    //als de speler in contact komt met de gekozen elementen dan word er een leven afgehaald en wor de private void endGame geactieveerd
                    lives = lives - 1;
                    endGame();
                }
            }

            //hieronder word het zelfde uitgevoer als hierboven maar dan voor de andere set buizen
            if (pipeTop2.Visible == true && pipeBottom2.Visible == true)
            {
                if (flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds)
                )
                {
                    lives = lives - 1;
                    endGame();
                }
            }

            //hier word gekeken als de speler de grond aanraakt, de grond is altijd zichtbaar
            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                //als de peler de groend heeft aangeraakt dan word er een zeven van af gehaald en word de private void endGame geactieveerd
                lives = lives - 1;
                endGame();
            }

            //hiewr word gekeken hoeveel levens de speler noch over heeft
            if (lives == 2)
            {
                //als er noch 2 levens zijn dan word leven 3 achtergrond kleur naar rood gezet en een label zegt
                //dat de speler noch maar 2 levens over heeft
                this.life3.BackColor = System.Drawing.Color.Red;
                lblLives.Text = "lives remaining: 2";
            }
            if (lives == 1)
            {
                //als er noch 1 leven is dan word leven 2 achtergrond kleur naar rood gezet en een label zegt
                //dat de speler noch maar 1 leven over heeft
                this.life2.BackColor = System.Drawing.Color.Red;
                lblLives.Text = "lives remaining: 1";
            }
            if (lives == 0)
            {
                //als er geen levens meer zijn dan word de private void finalScreen geactieveerd
                finalScreen();
            }

            //hier word gekeken als de score op dat moment het zlefde is als de scorestage die in het begin is gezet op 5
            if (score == scoreStage)
            {
                //als de zo is dan worden de pijpen sneller en wor de score stage +5 gedaan
                //als deze weer behaald word dan worden de pijpen weer sneller en word de scorestage weer +5 gedaan
                pipeSpeed = pipeSpeed + 1;
                scoreStage = scoreStage + 5; 
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            //als spatie knop word ingedrukt dan gaat de fallp bird zoveel omhoog
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
            //als de spatie knop word ingedukt en de retry kop is zightbaar dan dor de private void reset geactieveerd
            if (e.KeyCode == Keys.Enter && pbRetry.Visible == true)
            {
                reset();
            }

        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            //als de spatie knop word losgelaten dan gaat de flappy bird omlaag
            if(e.KeyCode == Keys.Space) 
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            //in deze void word de game gestopt

            //hiet word de game leterlijk stop gezet
            gameTimer.Stop();
            
            //het eindscherm word zichtbaar gemaakt, heirop staat hoeveel levend de speler noch heeft
            pnlEnd.Show();

            //hier word de bahaalde score + de eerder behaalde score gedaan
            endScore = endScore + score;

            //hier word gekeken als er 0 levens zijn of niet
            if (lives == 0)
            {
                //als er geen levens meer zijn dan word het volgende gezegd
                lblEndScore.Text = "end score: " + endScore.ToString();
            } else
            {
                //als er noch wel levens zijn dan word het zolgende gezegd
                lblEndScore.Text = "current score: " + endScore.ToString();
            }
            
        }

        private void reset()
        {
            //in deze void word de game gereset

            //de sore word weer op 0 gezet
            score = 0;

            //pijp snelheid word weer terug gezet
            pipeSpeed = 10;
            
            //score stage word weer op 5 terug gezet
            scoreStage = 5;

            //de buizen worden weer verborgen om het makkelijker te maken voor de speler om te starten
            pipeBottom1.Hide();
            pipeBottom2.Hide();
            pipeTop1.Hide();
            pipeTop2.Hide();

            //in de volgende 5 onderdelen worden de buizen en de fappy bird hun posieties compleet gereset
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

            //hier word de game weer gestart
            gameTimer.Start();

            //hier word het eindpaneel verborgen
            pnlEnd.Hide();

        }

        private void pbRetry_Click(object sender, EventArgs e)
        {
            //als er op de retry afbeelding/knop word geklikt dan word de private void reset geactiveerd
            reset();
        }

        private void finalScreen()
        {
            //in deze void word het eind form geactiveerd

            //hieronder word het laatste leven rood gemaakt en word der retry afbeelding/knop verborgen
            this.life1.BackColor = System.Drawing.Color.Red;
            lblLives.Text = "lives remaining: 0";
            pbRetry.Hide();
            retryInfo.Hide();

            //hier word de totale eindscore omgezet in een variabale
            int totalScore = endScore;

            //dit verbergt het game scherm 
            this.Hide();

            //hier word het laad scherm geactiveerd en er word informatie meegegeven
            loading loadingScreen = new loading("results");
            loadingScreen.Show();

            //hier word het game over form geactiveerd en de totaal behaalde score word mee gegeven
            gameOver gameOverForm = new gameOver(totalScore);
            gameOverForm.ShowDialog();

            //als het gameOverFrom word gesloten dan word het laad form ook automatisch gesloten
            loadingScreen.Close();

            //hier word de game afgesloten
            Close();
        }

    }
}
