using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FAQU
{
    class DataBase
    {
        SqlConnection connection = new SqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=automir");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection GetSqlConnection()
        {
            return connection;
        }
    }
}
