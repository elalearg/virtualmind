using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VirtualMinds.Services
{
    public class ConnectionFactory
    {
        public static DbConnection GetOpenConnection(string Conexion)
        {
            var connection = new SqlConnection(Conexion);
            connection.Open();

            return connection;
        }
    }
}