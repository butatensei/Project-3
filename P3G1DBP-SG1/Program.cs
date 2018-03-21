using System;
using System.IO;
using MySql.Data.MySqlClient;
using Npgsql;

namespace Project3Groep1
{
    class DBP
    {
        static void Main()
        {/*
            //Setting up connection to MySql:
            MySqlCommand cmd;
            string connStr = "server=localhost;user=root;port=3306;password=1411;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            //Creating the database:
            cmd = new MySqlCommand("Create Database if not exists 'fietsdief';", conn);
            cmd.ExecuteNonQuery();
*/
            var directory = Path.GetDirectoryName("Program.cs");
            Console.WriteLine(directory);
            /*
                        cmd = new MySqlCommand("", conn);

                        conn.Close();

                        Console.WriteLine("Setting up connection...");
                        Console.WriteLine("Enter username...");
                        var myUserName = Console.ReadLine();
                        Console.WriteLine("Enter password...");
                        var myPassword = Console.ReadLine();
                        var myConnection = ConnectToDatabase(myUserName, myPassword);
                        Console.WriteLine("Connection set up.");
                        Console.WriteLine("Enter SQL statement...");
                        var myStatement = Console.ReadLine();
                        var myReturn = EnterQuery(myStatement, myConnection);
                        Console.WriteLine(myReturn);
                        Console.WriteLine("Program complete.");
                        Console.WriteLine("Press any key to shut down...");
                        Console.ReadLine();
                    }

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
                    /*public string EnterQuery(string myStatement, NpgsqlConnection myConnection)
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

                    //static NpgsqlConnection ConnectToDatabase(string myUser, string myPassword)
                    /*
                    // Open database connection.
                    static void openConnection()
                    {
                       connection.Open();
                    }

                    // Close database connection.
                    private void closeConnection()
                    {
                        connection.Close();
                    }
                    */
        }
    }
}
