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

        public bool updateDatabase()
        {
            OpenConnection();
            string script = File.ReadAllText(@"P3G1.sql");
            MySqlCommand cmd = new MySqlCommand(script, connection);
            cmd.ExecuteNonQuery();
            CloseConnection();
            return true;
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


        //Current attempt at creating the list

            /*
             * Only works when update button is pressed (?)
             * Graph seems to stop working after update has been pressed, console does keep working tho.
             */

        /// <summary>
        /// Small class that stores variables that go into the query list
        /// </summary>
        public class CountTemp
        {
            public int Count { get; set; }
            public int TempGem { get; set; }
        }


        public List<CountTemp> DBselect(string passedQuery)
        {
            string query = passedQuery;

            //Create a list to store the result
            var list = new List<CountTemp>();

            //OPen connection
            if (this.OpenConnection())
            {
                //Create command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create datareader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(new CountTemp
                    {
                        Count = Convert.ToInt32(dataReader["Count(ID)"]),
                        TempGem = Convert.ToInt32(dataReader["TemperatuurGem"])

                    });
                    /*
                    foreach (var temp in list)
                    {
                        Console.WriteLine(string.Format("{0} {1}",
                            temp.Count,
                            temp.TempGem));
                    }*/// debug no longer needed 😎
                }

                //close datareader
                dataReader.Close();

                //close connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }

        }

        /*public void Display(List<CountTemp> list)
        {


        }*/


        /* Some messing around by Matthijs
        public List<string>[] dbSELECT(string passedQuery)
        {
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();
            string query = passedQuery;
            Console.WriteLine("start");

            //string conString = "Data Source=localhost;Initial Catalog=LoginScreen;Integrated Security=True";
            //MySqlConnection con = new MySqlConnection(conectionString);

            MySqlCommand com = new MySqlCommand(query, connection);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            //MySqlDataReader datareader = com.ExecuteReader();
            try
            {
                connection.Open();
                using (MySqlDataReader datareader = com.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        Console.WriteLine("hello");
                        list[0].Add(datareader["Count(ID)"] + "");
                        list[1].Add(datareader["TemperatuurGem"] + "");
                    }
                    return list;
                }
            }
            finally
            {
                connection.Close();
            }
        }
     
                try
                {
                    con.Open();

                    using (MySqlDataReader read = MySqlCommand.ExecuteReader())
                    {
                        while (cursor.Read())
                        {
                            //needs to be changed to whatever we want in the list
                            CustID.Text = (read["Customer_ID"].ToString());
                            CustName.Text = (read["Customer_Name"].ToString());
                        }
                    }
                }
                finally
                {
                    con.Close();
                }
            }
            con.Close();
        }*/



        /* Daniels setup + Ians (?) progress
        //Create a list to store the result
        List<string>[] list = new List<string>[2];
        list[0] = new List<string>();
        list[1] = new List<string>();


        //Open connection
        if (this.OpenConnection())
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            int iteration = 0;
            while (dataReader.Read())
            {
                foreach (System.Data.Common.DbDataRecord i in dataReader)
                {
                    iteration++;
                    Console.WriteLine("***LINE " + iteration + " ***");
                    Console.WriteLine(i.ToString());
                    //dataReader.GetInt16(i.ToString());
                    list[0].Add(dataReader["Count(ID)"] + "");
                    list[1].Add(dataReader["TemperatuurGem"] + "");
                }
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            Console.WriteLine("now printing list");
            foreach (var i in list)
            {
                Console.WriteLine(i);
                //Console.WriteLine([i]);
                Console.WriteLine(i[0]);
                //Console.WriteLine(i[i]);
            }
            return list;
        }
        else
        {
            return list;
        }

    } */

        //Performs a query to get a whole bunch of strings. Maybe.
        //Honestly, I just don't know anymore.
        /*public List<int>[] GetStringList(int, passedQuery)
        {
            //Create a list to store the result
            List<int>[] list = new List<int>[3];
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

