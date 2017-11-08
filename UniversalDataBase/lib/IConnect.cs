using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UniversalDataBase.lib
{
    public interface IConnect
    {
        
        conexion makeConnect(string usuario, string password, string driver, string host, string puerto, string service, string nombre);
        Boolean testConnection();
        DataTable returnResult(string query, out string mensaje);
        string returnName();

    }
}
