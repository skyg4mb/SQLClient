using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.DataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UniversalDataBase.lib;

namespace UniversalDataBase
{
    public partial class Inicio : Form
    {
        conexion conn = new conexion();

        public Inicio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect formulario = new connect();
            formulario.ShowDialog();
            IConnect conn = formulario.newConnection;
            

            userControls.userQueryScreen screen = new userControls.userQueryScreen();
            screen.connect = conn;
            screen.Dock = DockStyle.Fill;
            screen.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            try
            {
                TabPage tabConn = new TabPage();
                tabConn.Text = conn.returnName();
                tabConn.AutoScroll = true;
                tabConn.Controls.Add(screen);
                tabControl.TabPages.Add(tabConn);
            }
            catch
            {
                MessageBox.Show("No fue posible establecer una conexión", "Alerta SQL Client");
            }
             
            

        }
    }
}
