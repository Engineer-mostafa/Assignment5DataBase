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
    public partial class empthatworkincity : Form
    {
        Controller controllerObj;
        public empthatworkincity()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectProjectLoc();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Plocation";

            DataTable dt1 = controllerObj.SelectProjectLoc();
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Plocation";
        }

        private void empthatworkincity_Load(object sender, EventArgs e)
        {
           
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder();
            Object data = ValidationClass.isInteger(textBox1.Text, err);
            if (data == null)
            {
                MessageBox.Show(err.ToString());
                label4.Visible = true;
            }
            else
            {
                int x = (int)data;
                MessageBox.Show("The entered data is " + x);
                label4.Visible = false;

                controllerObj = new Controller();
            DataTable dt = controllerObj.Selectemployeesalaryandnames(comboBox1.Text,comboBox2.Text , x);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            }
           
        }
    }
}
