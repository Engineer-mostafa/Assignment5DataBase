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
    public partial class Provided_Functionalities : Form
    {
        Form Parent;
        public Provided_Functionalities(int a,Form Parent)
        {
            InitializeComponent();
            if (a == 0) //1 for admin, 0 for other
            {
                this.button1.Enabled = false;
            }
            this.Parent = Parent;
            if(Parent != null)
            Parent.Hide();
        }

        private void ViewProjectsButton_Click(object sender, EventArgs e)
        {
            RetrieveProjects RP = new RetrieveProjects();
            RP.Show();
           
        }

        private void ViewEmployeesButton_Click(object sender, EventArgs e)
        {
            ViewEmployees v = new ViewEmployees();
            v.Show();
           
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            AddProject p = new AddProject();
            p.Show();
        }

        private void Provided_Functionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Parent != null)
                Parent.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewDepartment newDepartment = new NewDepartment();
            newDepartment.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            empthatworkincity getall = new empthatworkincity();
            getall.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateSalary ups = new updateSalary();
            ups.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmployeeInfo ups = new EmployeeInfo();
            ups.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DepLoc DL = new DepLoc();
            DL.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FemaleDep FD = new FemaleDep();
            FD.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LName_Salary L = new LName_Salary();
            L.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MinMax M = new MinMax();
            M.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResearchDep M = new ResearchDep();
            M.Show();
        }
    }
}
