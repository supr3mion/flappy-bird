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
            mainScreen game = new mainScreen();
            game.ShowDialog();
        }

        private void start_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.Hide();

                mainScreen game = new mainScreen();
                game.ShowDialog();

                this.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

            highscore highscoreForm = new highscore();
            highscoreForm.ShowDialog();

            this.Show();
        }
    }
}
