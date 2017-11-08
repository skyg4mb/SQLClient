using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Teradata.Client.Provider;

namespace UniversalDataBase.lib
{
    class teradata : IConnect
    {
        public conexion conn;

        public conexion makeConnect(string usuario, string password, string driver, string host, string puerto, string service, string nombre)
        {
            conn = new conexion(usuario, password, driver, host, puerto, nombre);
            conn.StringConnection = "Data Source = " + conn.Host + "; User ID = " + conn.Usuario + "; Password = " + conn.Password + ";";
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
                using (TdConnection cn = new TdConnection(conn.StringConnection))
                {
                    cn.Open();
                    TdCommand cmd = cn.CreateCommand();
                    cmd.CommandText = @query;
                    cmd.CommandTimeout = 100000;
                    TdDataAdapter adapter = new TdDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var dt = ds.Tables[0];
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

            TdConnection connect = new TdConnection();
            connect.ConnectionString = conn.StringConnection;

            try
            {
                connect.Open();
                connect.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
