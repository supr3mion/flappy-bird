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
    public partial class gameOver : Form
    {

        //standaard waarden invullen

        private int playerScore = 0;

        private int lowestPlayerScore = 0;

        private int placement = 1;

        private int playerAmount = 0;

        private MySqlConnection connection;

        public gameOver(int totalScore)
        {
            //functies verbergen

            InitializeComponent();

            InitializeDatabaseConnection();

            tbName.Hide();
            pbCrown.Hide();
            btnSubmitHighScore.Hide();
            pbNewHighScore.Hide();

            //meegegeven score omzetten naar waarde die ik overal in deze code kan gebruiken
            playerScore = totalScore;

            //totaal behaalde score laten zien aan speler
            lblPlayerScore.Text = "totaal score: " + playerScore.ToString();
            
            //actievatie: private void lowestScore om de laagste score op te halen
            lowestScore(1);

            //kijken als de behaalde score groter is dan de laagste score in de database
            if (playerScore > lowestPlayerScore)
            {
                //alle onderdelen die niet en wel nodig zijn worden verborgen of zichtbaar
                tbName.Show();
                pbCrown.Show();
                btnSubmitHighScore.Show();
                pbNewHighScore.Show();
                btnClose.Hide();

                //actievatie: private void lowestScore om plaats van speler te be palen
                lowestScore(10);

                //kijken als de score hoger is dan 1 of niet (dit is puur voor de spelling)
                if (placement > 1)
                {
                    //instructies geven samen met waarschuwing
                     lblHighScoreInfo.Text = "NEW HIGHSCORE, u bent " + placement.ToString() + "e geplaatst" + "\r\n" + "vul hieronder uw naam in" + "\r\n" + "(waarschuwing: andere spelers kunnen de gekozen naam zien)";
                } 
                else
                {
                    //instructies geven samen met waarschuwing
                    lblHighScoreInfo.Text = "NEW HIGHSCORE, u bent " + placement.ToString() +"st geplaatst" + "\r\n" + "vul hieronder uw naam in" + "\r\n" + "(waarschuwing: andere spelers kunnen de gekozen naam zien)";
                }


            }
            else
            {
                //instructies geven
                lblHighScoreInfo.Text = "geen nieuwe highscore behaald" + "\r\n" + "klik hieronder om terug te gaan naar het start scherm";
            }

        }

        private void InitializeDatabaseConnection()
        {
            //database connectie opbouwen
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
            //connectie verbreken als connectie nog open staat
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

        private void sqlInsert()
        {
            //connectie openen
            OpenConnection();
            
            //database query maken om de nieuwe score toe te voegen
            string insertQuery = "INSERT INTO highscore (name, score) VALUES (@name, " + playerScore + ")";

            //eerder gemaakte database query uitvoeren
            MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

            //waarden voor database query bepalen
            cmd.Parameters.Add("@name", MySqlDbType.VarChar,225);

            cmd.Parameters["@name"].Value = tbName.Text;

            //checken als database query is uitgevoerd
            if (cmd.ExecuteNonQuery() == 1)
            {
                //instructies geven
                lblHighScoreInfo.Text = "score opgeslagen" + "\r\n" + "klik hieronder om terug te gaan naar het start scherm";

                //onnodige onderdelen verbergen en nodige onderdelen laten verschijnen
                tbName.Hide();
                btnSubmitHighScore.Hide();
                btnClose.Show();
            }

            //connectie sluiten
            CloseConnection();
            
        }

        private void sqlDelete()
        {
            //connectie openen
            OpenConnection();

            //sql query opbouwen om de laagste score uit de database te halen
            string deleteQuery = "DELETE FROM highscore ORDER BY score LIMIT 1";

            //sql query uitvoeren
            MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);

            //sql query activeren
            cmd.ExecuteNonQuery();

            //connectie sluiten
            CloseConnection();

        }

        private int lowestScore(int amount)
        {
            //database connectie openen
            OpenConnection();

            //sql query opbouwen om de laagste of laagste 10 scores uit de database te halen
            string sqlQuery = "SELECT * FROM highscore ORDER BY score LIMIT " + amount;

            //kijken als de database connectie open staat
            if (this.OpenConnection() == true)
            {
                //sql query uitvoeren
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                //sql query activeren en er een reader van maken
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //while op zetten die zolanga als er informatie komt de volgende code blijft herhalen
                while (dataReader.Read())
                {
                    //score ophalen
                    string localScore = dataReader["score" + ""].ToString();

                    //store van text naar cijfer omzetten
                    lowestPlayerScore = Convert.ToInt32(localScore);

                    //opgehaalde aantal scores in de database optellen
                    playerAmount++;

                    //als de top 10 scores worden opgehaald dan word het volgende gadaan
                    if (amount == 10)
                    {
                        //kijken als de opgehaalde score groter is dan de behaalde score van de speler
                        if (lowestPlayerScore > playerScore)
                        {
                            //plaats van niewbehaalde highscore word berekend
                            placement++;
                        }
                    }
                }

                //de reader afsluiten
                dataReader.Close();

                //kijken als de top 10 word opgehaald om te bereken op welke plaats de nieuwe highscore staat
                if (amount == 10)
                {
                    //geeft de plaats van nieuwe highscore terug aan code
                    return placement;
                }
                else
                {
                    //geeft de laagste score die is opgehaald terug aan code
                    return lowestPlayerScore;
                }

                //connectie sluiten
                CloseConnection();
            }
            //als er geen connectie is gemaakt met de database
            else
            {
                //kijken als de top 10 word opgehaald om te bereken op welke plaats de nieuwe highscore staat
                if (amount == 10)
                {
                    //geeft de plaats van nieuwe highscore terug aan code
                    return placement;
                }
                else
                {
                    //geeft de laagste score die is opgehaald terug aan code
                    return lowestPlayerScore;
                }

                //connectie sluiten
                CloseConnection();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //als er op deze knop word geklikt dan word dit paneel gesloten
            Close();
        }

        private void btnSubmitHighScore_Click(object sender, EventArgs e)
        {
            //als er op deze knop word geklikt dan worden de volgende voids uitgevoerd

            //private void sqlInsert word uitgevoerd
            sqlInsert();

            //hier word gekeken hoeveel spelers in de database staan
            //de reden dat dit 11 is en niet 10 is omdat de private int lowestScore 2x word uitgevoerd 
            //en er daarom 2x een waarde teurg komt en dat zijn 1 en 10 
            if (playerAmount == 11)
            {
                //private void sqlDelete word uitgevoerd
                sqlDelete();
            }
        }
    }
}
