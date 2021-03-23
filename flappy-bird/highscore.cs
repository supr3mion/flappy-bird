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

        private int placement = 1;

        public highscore()
        {
            InitializeComponent();

            InitializeDatabaseConnection();

            lblHighScoresName.Text = "";
            lblHighScoresScore.Text = "";

            string sqlQuery = "SELECT * FROM highscore ORDER BY score DESC LIMIT 10";

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    lblHighScoresName.Text = lblHighScoresName.Text + placement + "st place: " + dataReader["name"] + "\n\r";
                    lblHighScoresScore.Text = lblHighScoresScore.Text + " met een score van: " + dataReader["score"] + "\n\r";
                    placement++;
                }

                dataReader.Close();

                this.CloseConnection();

            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            Close();
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

        public List<string>[] GetAllDevices()
        {
            string sqlQuery = "SELECT * FROM highscore ORDER BY score LIMIT 10";

            List<string>[] resultList = new List<string>[2];
            resultList[0] = new List<string>();
            resultList[1] = new List<string>();

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    resultList[0].Add(dataReader["name"] + "");
                    resultList[1].Add(dataReader["score "] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return resultList;
            }
            else
            {
                return resultList;
            }
        }
    }
}
