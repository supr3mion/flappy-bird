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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void pbStart_Click(object sender, EventArgs e)
        {

            this.Hide();

            //als er op deze afbeelding/knop word geklikt dan word het spel gestart, er worden geen waarden mee gegeven
            //ook word dit scherm verborgen door de this.Hide() functie
            mainScreen game = new mainScreen();
            game.ShowDialog();

            //als het game scherm is afgesloten dan wor dit scherm weer zichtbaar gemaakt
            this.Show();
        }

        private void start_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //als de spatie knop is ingedrukt dan word de game gestart
            if (e.KeyCode == Keys.Space)
            {
                //ook hier word er geen waarde mee gegeven naar de game en de manier van het statren is het zelfde als in de void hierboven
                this.Hide();

                mainScreen game = new mainScreen();
                game.ShowDialog();

                this.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //als er op deze afbeelding/knop word geklikt dan word dit scherm verborgen
            this.Hide();

            //het laad scherm word geactiveerd met de waarde "highscores"
            loading loadingScreen = new loading("highscores");
            loadingScreen.Show();

            //het scherm met alle highscores word geladen
            highscore highscoreForm = new highscore();
            highscoreForm.ShowDialog();

            //als het highscores scherm word afgesloten dan stuit het laad scherm ook automatisch
            //en word dit scherm weer zichtbaar gemaakt
            loadingScreen.Close();

            this.Show();
        }
    }
}
