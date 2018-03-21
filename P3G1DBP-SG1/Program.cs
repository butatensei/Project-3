using System;
using MySql.Data.MySqlClient;

namespace Project3Groep1
{
    class DBP
    {



        class DBConnect
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

            //Initialize values
            private void Initialize()
            {
                server = "localhost";
                database = "connectcsharptomysql";
                uid = "username";
                password = "password";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(connectionString);
            }

            //open connection to database
            private bool OpenConnection()
            {
            }

            //Close connection
            private bool CloseConnection()
            {
            }

            //Insert statement
            public void Insert()
            {
            }

            //Update statement
            public void Update()
            {
            }

            //Delete statement
            public void Delete()
            {
            }

            //Select statement
            public List<string>[] Select()
            {
            }

            //Count statement
            public int Count()
            {
            }

            //Backup
            public void Backup()
            {
            }

            //Restore
            public void Restore()
            {
            }
        }
        /*
        /// <summary>
        /// Sets up a connection to a database.
        /// </summary>
        /// <param name="myUser">The username for the database.</param>
        /// <param name="myPassword">The password for the database.</param>
        /// <returns>NpgsqlConnection</returns>
        static NpgsqlConnection ConnectToDatabase(string myUser, string myPassword)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;" +
                "Port=5432;" +
                "User Id=" + myUser + ";" +
                "Password=" + myPassword + ";" +
                "Database=mydatabase;"
            );
            return connection;
        }
        
        
        /// <summary>
        /// Executed a statement on the connected server
        /// </summary>
        /// <param name="myUser">The username for the database.</param>
        /// <param name="myPassword">The password for the database.</param>
        /// <returns>NpgsqlConnection</returns>
        public string EnterQuery(string myStatement, NpgsqlConnection myConnection)
        {
            myConnection.Open();
            var myReturn = NpgsqlCommand(myStatement, myConnection);
            myConnection.Close();
            return myReturn;
        }

        static bool EnterQuery(string myStatement, NpgsqlConnection myConnection)
        {
            myConnection.Open();
            using (var cmd = new NpgsqlCommand("SELECT some_field FROM data", myConnection))
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                    Console.WriteLine(reader.GetString(0));
            myConnection.Close();
            return true;
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Setting up connection...");
            Console.WriteLine("Enter username...");
            //var myUserName = Console.ReadLine();
            Console.WriteLine("Enter password...");
            //var myPassword = Console.ReadLine();
            //var myConnection = ConnectToDatabase(myUserName, myPassword);
            Console.WriteLine("Connection set up.");
            Console.WriteLine("Enter SQL statement...");
            //var myStatement = Console.ReadLine();
            //var myReturn = EnterQuery(myStatement, myConnection);
            Console.WriteLine(myReturn);
            Console.WriteLine("Program complete.");
            Console.WriteLine("Press any key to shut down...");
            Console.ReadLine();
        }
    }
}
