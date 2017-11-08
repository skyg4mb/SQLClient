using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using System.Linq;
using System.Text;

namespace UniversalDataBase.lib
{
    class oracle : IConnect
    {
        public conexion conn;
        public conexion makeConnect(string usuario, string password, string driver, string host, string puerto, string service, string nombre)
        {
            conn = new conexion(usuario, password, driver, host, puerto, service, nombre);
            conn.StringConnection = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + host + ")(PORT=" + puerto + ")))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=" + service + ")));User Id=" + usuario + ";Password=" + password + ";";
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
                using (OracleConnection cn = new OracleConnection(conn.StringConnection))
                {
                    cn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = @query;
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
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
            string oradb = conn.StringConnection;
            OracleConnection connection = new OracleConnection(oradb);  // C#

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
