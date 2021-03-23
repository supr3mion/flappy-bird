﻿using System;
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
        private int playerScore = 0;

        private int lowestPlayerScore = 0;

        private MySqlConnection connection;

        public gameOver(int totalScore)
        {
            InitializeComponent();

            InitializeDatabaseConnection();

            tbName.Hide();
            pbCrown.Hide();
            btnSubmitHighScore.Hide();
            pbNewHighScore.Hide();

            playerScore = totalScore;

            lblPlayerScore.Text = "totaal score: " + playerScore.ToString();

            lowestScore();

            if (playerScore > lowestPlayerScore)
            {
                tbName.Show();
                pbCrown.Show();
                btnSubmitHighScore.Show();
                pbNewHighScore.Show();
                btnClose.Hide();

                lblHighScoreInfo.Text = "NEW HIGHSCORE" + "\r\n" + "vul hieronder uw naam in" + "\r\n" + "(waarschuwing: andere spelers kunnen de gekozen naam zien)";

            }
            else
            {
                lblHighScoreInfo.Text = "geen nieuwe highscore behaald" + "\r\n" + "klik hieronder om terug te gaan naar het start scherm";
            }

        }

        private void InitializeDatabaseConnection()
        {
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
            OpenConnection();
            
            string insertQuery = "INSERT INTO highscore (name, score) VALUES (@name, " + playerScore + ")";

            MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

            cmd.Parameters.Add("@name", MySqlDbType.VarChar,225);

            cmd.Parameters["@name"].Value = tbName.Text;


            if (cmd.ExecuteNonQuery() == 1)
            {
                lblHighScoreInfo.Text = "score opgeslagen" + "\r\n" + "klik hieronder om terug te gaan naar het start scherm";

                tbName.Hide();
                btnSubmitHighScore.Hide();
                btnClose.Show();
            }

            CloseConnection();
            
        }

        private int lowestScore()
        {
            OpenConnection();

            string sqlQuery = "SELECT * FROM highscore ORDER BY score LIMIT 1";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string localScore = dataReader["score" + ""].ToString();

                    lowestPlayerScore = Convert.ToInt32(localScore);
                }

                dataReader.Close();

                return lowestPlayerScore;

                CloseConnection();
            }
            else
            {
                return lowestPlayerScore;

                CloseConnection();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmitHighScore_Click(object sender, EventArgs e)
        {
            sqlInsert();
        }
    }
}