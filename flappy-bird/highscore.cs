using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class highscore : Form
    {

        private MySqlConnection connection;

        //hier word de standaard waarde ingestelt
        private int placement = 1;

        public highscore()
        {
            //hier word het form delen geactieveerd
            InitializeComponent();
            InitializeDatabaseConnection();

            //hier word de text gereset
            lblHighScoresName.Text = "";
            lblHighScoresScore.Text = "";

            //hier word een sql gemaakt op de top 10 scores op te halen
            string sqlQuery = "SELECT * FROM highscore ORDER BY score DESC LIMIT 10";

            //hier word er gekeken als er een connectie is met de database
            if (this.OpenConnection() == true)
            {
                //hier word de qls uitgevoerd
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                //hier word er een reader er opgezet
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //het volgende stuk word herhaald tot dat de reader niks meer leest, vanwege de sql is dit 10
                while (dataReader.Read())
                {
                    //hier worden de naam en de score van de speler opgehaald en in een label gezet in het highscores scherm
                    //heir word ook de als bestaande text + de nieuwe text gedaan en zo word er een lijst gemaakt van alle spelers die een highscore hebben
                    lblHighScoresName.Text = lblHighScoresName.Text + placement + "st place: " + dataReader["name"] + "\n\r";
                    lblHighScoresScore.Text = lblHighScoresScore.Text + " met een score van: " + dataReader["score"] + "\n\r";

                    //hier word de plaats +1 gedaan van de de volgende speler (de standaard waarde is 1)
                    placement++;
                }

                //hier word de datareader afgesloten
                dataReader.Close();

                //hier word de database connectie verbroken
                this.CloseConnection();

            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            //als er op deze afbeelding/knop word geklikt dan word dit scherm afgesloten
            Close();
        }

        private void InitializeDatabaseConnection()
        {
            //hier word database informatie ingevoerd
            string server = "localhost";
            string database = "Flappy-bird";
            string dbUsername = "root";
            string dbPassword = "";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            //hier word de database connectie gemaakt

            CloseConnection();

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {

            //hier word de database connectie gesloten
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
