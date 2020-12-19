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

    public partial class EmployeeInfo : Form
    {
        Controller controllerObj;

        public EmployeeInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder();
            Object data = ValidationClass.isInteger(Dname.Text, err);
            if (data == null)
            {
                label4.Visible = true;
            }
            else
            {
                int x = (int)data;
                label4.Visible = false;

                controllerObj = new Controller();
                DataTable dt = controllerObj.Selectssnandaddress(x);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }
    }
}
