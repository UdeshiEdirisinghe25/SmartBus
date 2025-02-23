using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace SmartBus
{
    class DBconnection
    {
        static readonly string server = "localhost";
        static readonly string database = "Smartbus";
        static readonly string user = "root";
        static readonly string password = "";
        public static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "USER=" + user + ";" + "PASSWORD=" + password + ";";
        public MySqlConnection mysqlconnection = new MySqlConnection(connectionString);
        public bool connect_db()
        {
            try
            {
                mysqlconnection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool close_db()
        {
            try
            {
                mysqlconnection.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

    }
}
