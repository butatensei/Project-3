using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace Project3Groep1
{
    /// <summary>
    /// Object that holds a connection to the database, and hosts all our database-related functions/methods.
    /// </summary>
    class DBConnect//Database connection object
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values -- make sure you adjust the info
        private void Initialize()
        {
            server = "localhost";
            database = "p3g1";
            uid = "root";
            password = "project3groep1";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public void update()
        {
            OpenConnection();
            string script = File.ReadAllText(@"P3G1.sql");
            MySqlCommand cmd = new MySqlCommand(script, connection);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        break;

                    case 1045:
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        //Performs a query to get a whole bunch of strings. Maybe.
        //Honestly, I just don't know anymore.
        /*public List<string>[] GetStringList(string, passedQuery)
        {
            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(passedQuery, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader.GetFieldValue(1));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }*/

        //Count statement
        //Another proof of concept, but this one is called in the testButton in the form.
        /// <summary>
        /// Takes a Select Count() query, returns an integer
        /// </summary>
        /// <param name="passedQuery">SELECT Count() query</param>
        /// <returns>int</returns>
        public int Count(string passedQuery)
        {
            //string query = "SELECT Count(*) FROM weer";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(passedQuery, connection);

                //ExecuteScalar will return one value
                //Count = int.Parse(cmd.ExecuteScalar() + "");
                var scholar = cmd.ExecuteScalar();
                Count = Convert.ToInt32(scholar);
                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
