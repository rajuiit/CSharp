using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DemoAddDeleteUpdate
{
    class dbConnect
    {

        MySqlConnection connection = Initialize();
        //For initialize
        public static MySqlConnection Initialize()
         {
           
            MySqlConnection connection;
            string connectionString;

            string server = "localhost";
            string database = "gradingsystem_db";
            string uid = "root";
            string password = "";
            
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

            return connection;
        }
        }
        }
