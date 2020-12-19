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
    
    public partial class LName_Salary : Form
    {
        Controller controllerObj;
        public LName_Salary()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectLName_Salary();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectLName_Salary();
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }
    }
}
