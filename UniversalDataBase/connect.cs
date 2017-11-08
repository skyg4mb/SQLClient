using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniversalDataBase.lib;

namespace UniversalDataBase
{
    public partial class connect : Form
    {
        public IConnect newConnection;
        public connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "False";
            conexion conn = new conexion();

            switch (driver.SelectedItem.ToString())
            {
                case "Teradata":
                    newConnection = new teradata();
                    conn = newConnection.makeConnect(usuario.Text, password.Text, "Teradata",
                        host.Text, puerto.Text, service.Text, nombre.Text);
                    result = newConnection.testConnection().ToString();
                    break;
                case "Oracle":
                    newConnection = new oracle();
                    conn = newConnection.makeConnect(usuario.Text, password.Text, "Oracle",
                        host.Text, puerto.Text, service.Text, nombre.Text);
                    result = newConnection.testConnection().ToString();
                    break;
                case "SQL Server":
                    newConnection = new mssql();
                    conn = newConnection.makeConnect(usuario.Text, password.Text, "MsSql",
                        host.Text, puerto.Text, service.Text, nombre.Text);
                    result = newConnection.testConnection().ToString();
                    break;
            }

            if (result == "True")
            {
                this.Close();
            }
            else { MessageBox.Show("Se presento un error en la conexion"); }


        }

        private void connect_Load(object sender, EventArgs e)
        {

        }
    }
}
