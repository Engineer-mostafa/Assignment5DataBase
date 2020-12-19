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
    public partial class FemaleDep : Form
    {
        Controller controllerObj;
        public FemaleDep()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepName();
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Dname";

        }

        private void FemaleDep_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Female_Department(comboBox3.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
