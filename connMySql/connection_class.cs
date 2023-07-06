using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UI.connMySql
{
   
    class Connection_class
    {
        public MySqlConnection conndb;
        public Connection_class()
        {
            string server = "127.0.0.1";
            string database = "centralized_procurement_system";
            string username = "root";
            string password = "";
            string constring = "server=" + server + ";database=" + database + ";username=" + username + ";password=" + password;

            conndb = new MySqlConnection(constring);
        }
        
    }
}
