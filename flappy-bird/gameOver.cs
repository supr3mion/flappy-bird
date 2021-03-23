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
        private int playerScore = 0;

        private int lowestPlayerScore = 0;

        private int localScore = 0;

        private MySqlConnection connection;

        public gameOver(int totalScore)
        {
            InitializeComponent();

            InitializeDatabaseConnection();

            tbName.Hide();

            playerScore = totalScore;

            lowestScore();

            //label1.Text = localScore.ToString();


            //place(1);

            ////kijkt als de opgehaalde score lager is dan de score die op eerste plaats staat in de database
            ////als dat het geval is dan gaat hij verder met de 2e plaats en zo verder
            //if (score < playerScore)
            //{
            //    place(2);

            //    if (score < playerScore)
            //    {
            //        place(3);

            //        if (score < playerScore)
            //        {

            //            place(4);

            //            if (score < playerScore)
            //            {
            //                placement = 4;
            //            }
            //        } else
            //        {
            //            tbName.Show();

            //        }
            //    } else
            //    {
            //        tbName.Show();

            //    }
            //} else
            //{
            //    tbName.Show();

            //}

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

        //private int place(int place)
        //{
        //    OpenConnection();

        //    string sqlQuery = "SELECT * FROM highscore WHERE place = " + place;

        //    if (this.OpenConnection() == true)
        //    {
        //        MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

        //        MySqlDataReader dataReader = cmd.ExecuteReader();

        //        if (dataReader.Read())
        //        {
        //            int playerScore = Convert.ToInt32(dataReader["score"] + "");
        //        }
        //    }
        //    CloseConnection();
        //    return score;
        //}

        private void sqlInsert()
        {
            OpenConnection();

            if (this.OpenConnection() == true)
            {
                string insertQuery = "INSERT INTO highscore (name, score) VALUES (@name, " + playerScore + ")";

                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

                cmd.Parameters.Add("@name", MySqlDbType.VarChar);

                cmd.Parameters["@name"].Value = tbName.Text;

            }

            CloseConnection();
            
        }

        //private int[] GetAllScores()
        //{
            
        //    OpenConnection();

        //    string sqlQuery = "SELECT * FROM highscore";

        //    int[] allScores = new int[1];
        //    allScores[0] = new int();

        //    if (this.OpenConnection() == true)
        //    {
        //        MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

        //        MySqlDataReader dataReader = cmd.ExecuteReader();

        //        while (dataReader.Read())
        //        {
        //            allScores[0].Add(dataReader["score" + ""]).ToString();
        //        }
        //        dataReader.Close();

        //        CloseConnection();

        //        return allScores;
        //    }
        //    else
        //    {
        //        return allScores;
        //    }
        //}

        public List<int>[] GetAllScores()
        {
            OpenConnection();

            string sqlQuery = "SELECT * FROM highscore ORDER BY score";

            //SELECT * FROM highscore ORDER BY score DESC LIMIT 1


            List<int>[] allScores = new List<int>[1];
            allScores[0] = new List<int>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    allScores[0].Add(Convert.ToInt32(dataReader["score" + ""]));
                }
                dataReader.Close();

                CloseConnection();

                return allScores;
            }
            else
            {
                return allScores;

                CloseConnection();
            }
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

                    label1.Text = lowestPlayerScore.ToString();
                }
                
                return lowestPlayerScore;

                CloseConnection();
            }
            else
            {
                return lowestPlayerScore;

                CloseConnection();
            }
        }
    }
}
