using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalDataBase.lib
{
    public class conexion
    {
        string usuario;
        string password;
        string driver;
        string host;
        string puerto;
        string stringConnection;
        string service;
        string nombre;

        public conexion(string usuario, string password, string driver, string host, string puerto, string nombre)
        {
            this.usuario = usuario;
            this.password = password;
            this.driver = driver;
            this.host = host;
            this.puerto = puerto;
            this.Nombre = nombre;
        }

        public conexion(string usuario, string password, string driver, string host, string puerto, string service, string nombre)
        {
            this.usuario = usuario;
            this.password = password;
            this.driver = driver;
            this.host = host;
            this.puerto = puerto;
            this.service = service;
            this.Nombre = nombre;
        }
        public conexion()
        {

        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }

        public string Host
        {
            get
            {
                return host;
            }

            set
            {
                host = value;
            }
        }

        public string Puerto
        {
            get
            {
                return puerto;
            }

            set
            {
                puerto = value;
            }
        }

        public string StringConnection
        {
            get
            {
                return stringConnection;
            }

            set
            {
                stringConnection = value;
            }
        }

        public string Service
        {
            get
            {
                return service;
            }

            set
            {
                service = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}
