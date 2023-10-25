using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;

namespace SQLtoCSV
{
    //This class will help the form in connection stuff
    //If something goes wrong, you can fix errors here and not edit all the solution!
    public class DBHelper
    {
        private static DBHelper instance; //<-
        private SqlConnection connection;
        private string connectionString = @"your connection string here";

        private DBHelper() //<-
        {
            connection = new SqlConnection(connectionString);
        }
        public static DBHelper GetNewDBHelper() //<-
        {
            if ( instance == null)
            {
                instance = new DBHelper();
            }
            return instance;
        }
        //Singleton DBHelper (<-)

        public DataTable Select(string table)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(connectionString, connection);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + table;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            connection.Close();
            return dt;
        }

        public DataTable CboFiller()
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(connectionString, connection);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            connection.Close();
            return dt;
        }
    }
}
