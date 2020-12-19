using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class MinMax : Form
    {
        Controller controllerObj;
        public MinMax()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.MinMax_Salary();
        }

        private void MinMax_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.MinMax_Salary();
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
