using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace I_veru_chto_eto_Konec
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server = 	localhost; port = 3306; username = root; password = root; database = vova");
    public void openConn()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConn()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConn()
        {
            return connection;
        }
    }
}
