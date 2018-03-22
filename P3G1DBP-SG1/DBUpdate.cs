using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace Project3Groep1
{
    class DBUpdate
    {
        public static MySqlConnection connection;

        public static void update()
        {

        DBConnect Updating = new DBConnect();
        Updating.Initialize();
        Updating.OpenConnection();
        string script = File.ReadAllText(@"P3G1.sql");
        MySqlCommand cmd = new MySqlCommand(script, connection);
        cmd.ExecuteNonQuery();
        }
    }
}

