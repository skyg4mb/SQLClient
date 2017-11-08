using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniversalDataBase.userControls
{
    public partial class userQueryScreen : UserControl
    {
        public lib.IConnect connect;

        public userQueryScreen()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = connect.returnResult(textBoxQuery.Text);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userQueryScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
