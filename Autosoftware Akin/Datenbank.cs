using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosoftware_Akin
{
    class Datenbank
    {
        public DataSet dataset = new DataSet();
        public static MySqlConnection connection = new MySqlConnection();


        public Datenbank()
        {
            const string conString = "server=localhost; port=3306; username=root; database=autosdb";
            connection = new MySqlConnection("server=localhost; port=3306; username=root; database=autosdb");
        }


    }
}
