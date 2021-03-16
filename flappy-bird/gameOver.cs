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

        private int score = 0;
        private int first = 0;
        private int second = 0;
        private int third = 0;

        private MySqlConnection connection;

        public gameOver(int totalScore)
        {
            InitializeComponent();

            InitializeDatabaseConnection();

            tbName.Hide();

            score = totalScore;

            place1();
            
            if (score < first)
            {
                place2();

                if (score < second)
                {
                    place3();

                    if (score < third)
                    {
                        tbName.Hide();
                    } else
                    {
                        tbName.Show();
                    }
                } else
                {
                    tbName.Show();
                }
            } else
            {
                tbName.Show();
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

        private int place1()
        {
            OpenConnection();

            string sqlQuery = "SELECT * FROM apparaten WHERE place = " + 1;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    int first = Convert.ToInt32(dataReader["score"] + "");
                }
            }
            CloseConnection();
            return first;
        }

        private int place2()
        {
            OpenConnection();

            string sqlQuery = "SELECT * FROM apparaten WHERE place = " + 2;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    int second = Convert.ToInt32(dataReader["score"] + "");
                }
            }
            CloseConnection();
            return second;
        }

        private int place3()
        {
            OpenConnection();

            string sqlQuery = "SELECT * FROM apparaten WHERE place = " + 3;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    int third = Convert.ToInt32(dataReader["score"] + "");
                }
            }
            CloseConnection();
            return third;
        }

    }
}
