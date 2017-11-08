using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace UniversalDataBase.lib
{
    class mssql : IConnect
    {
        public conexion conn;

        public conexion makeConnect(string usuario, string password, string driver, string host, string puerto, string service, string nombre)
        {
            conn = new conexion(usuario, password, driver, host, puerto, service, nombre);
            conn.StringConnection = "Server="+host+";Database="+service+";User Id="+usuario+";Password = "+password+"; ";
            return conn;
        }

        public string returnName()
        {
            return conn.Nombre;
        }

        public DataTable returnResult(string query)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn.StringConnection))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = @query;
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool testConnection()
        {
            string sqldb = conn.StringConnection;
            SqlConnection connection = new SqlConnection(sqldb);  // C#

            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
