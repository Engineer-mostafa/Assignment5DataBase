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
    public partial class NewDepartment : Form
    {
        Controller controllerObj;
        public NewDepartment()
        {
            InitializeComponent();
        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthDate_Click(object sender, EventArgs e)
        {

        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void middleName_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            var dt = dateTimeBox.Value.ToString();
            string month = "";
            string day = "";
            string year = "";

            for (int i = 0; i < 2; i++)
            {
                if (dt[i] != '/')
                {
                    month += dt[i];
                    continue;
                }
                break;
            }

            for (int i = month.Length + 1; i < month.Length + 3; i++)
            {
                if (dt[i] != '/')
                {
                    day += dt[i];
                    continue;
                }
                break;
            }

            for (int i = month.Length + day.Length + 2; i < month.Length + day.Length + 6; i++)
            {
                if (dt[i] != '/')
                {
                    year += dt[i];
                    continue;
                }
                break;
            }


            StringBuilder err0 = new StringBuilder();
            StringBuilder err1 = new StringBuilder();
            Object data0 = ValidationClass.isInteger(Dnumber.Text, err0);
            Object data1 = ValidationClass.isInteger(manager_ssn.Text, err1);
            if (data0 == null)
            {
                MessageBox.Show("Department Number Should be integer > 0 "+err0.ToString());
            }
            else if(data1 == null)
            {
                MessageBox.Show("Manager SNN Should be integer > 0 " + err1.ToString());
            }
            else
            {
                if (depLocation.Text == null || depLocation.Text == "" && Dname.Text == null || Dname.Text == "")
                {
                    MessageBox.Show("You Should Enter Location And Department Name");
                    return;
                }
                else if(depLocation.Text == null || depLocation.Text == "")
                {
                    MessageBox.Show("You Should Enter Location");
                    return;
                }
                else if(Dname.Text == null || Dname.Text == "")
                {
                    MessageBox.Show("You Should Enter Department Name");
                    return;
                }
                if (controllerObj.InsertDepartment(Dname.Text, int.Parse(Dnumber.Text), int.Parse(manager_ssn.Text), year + "-" + month + "-" + day) == 1)
                {
                    controllerObj.InsertDepartmentLocation(depLocation.Text, int.Parse(Dnumber.Text));
                    MessageBox.Show("Successfully Inserted ✔️");
                }
                else
                {
                    MessageBox.Show("Sorry We Have Error in Manager SSN or in Department Number ❌");

                }


            }
           
        }
    }
}
