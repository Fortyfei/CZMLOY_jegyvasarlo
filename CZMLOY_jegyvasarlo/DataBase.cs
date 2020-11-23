using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CZMLOY_jegyvasarlo
{
    class DataBase
    {
        private SQLiteConnection conn = new SQLiteConnection("data source=szinhaz.db");

        public SQLiteConnection GetConnecton()
        {
            return conn;
        }

        public void openConn()
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }

        public void closeConn()
        {
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
        }


    }
}
