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
    public partial class updateSalary : Form
    {
        Controller controllerObj;

        public updateSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StringBuilder err0 = new StringBuilder();
            Object data0 = ValidationClass.isInteger(empSSN.Text, err0);
            StringBuilder err1 = new StringBuilder();
            Object data1 = ValidationClass.isInteger(newSalary.Text, err1);
            if (data0 == null && data1 == null)
            {
                
                label1.Visible = true;
                label2.Visible = true;
            }
            else if(data0 == null)
            {
                label1.Visible = true;
                label2.Visible = false;

            }
            else if(data1 == null)
            {
                label2.Visible = true;
                label1.Visible = false;

            }
            else
            {
                int x = (int)data0;
                label1.Visible = false;
                label2.Visible = false;

                 controllerObj = new Controller();
            if(controllerObj.updateSalary(int.Parse(empSSN.Text), int.Parse(newSalary.Text)).ToString() == "0" )
                {
                    MessageBox.Show("No Employee With This SSN ❌");
                }
                else
                {
                    MessageBox.Show("Successfully Updated ✔️");
                }
            }
           
        }
    }
}
