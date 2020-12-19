
namespace DBapplication
{
    partial class NewDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.manager_ssn = new System.Windows.Forms.TextBox();
            this.Dnumber = new System.Windows.Forms.TextBox();
            this.Dname = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.Label();
            this.labbbel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.inserttitlepanel = new System.Windows.Forms.Panel();
            this.depLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inserttitlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.Location = new System.Drawing.Point(198, 216);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBox.TabIndex = 53;
            this.dateTimeBox.ValueChanged += new System.EventHandler(this.dateTimeBox_ValueChanged);
            // 
            // manager_ssn
            // 
            this.manager_ssn.Location = new System.Drawing.Point(198, 146);
            this.manager_ssn.Name = "manager_ssn";
            this.manager_ssn.Size = new System.Drawing.Size(100, 20);
            this.manager_ssn.TabIndex = 52;
            this.manager_ssn.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
            // 
            // Dnumber
            // 
            this.Dnumber.Location = new System.Drawing.Point(198, 110);
            this.Dnumber.Name = "Dnumber";
            this.Dnumber.Size = new System.Drawing.Size(100, 20);
            this.Dnumber.TabIndex = 51;
            this.Dnumber.TextChanged += new System.EventHandler(this.middleNameBox_TextChanged);
            // 
            // Dname
            // 
            this.Dname.BackColor = System.Drawing.Color.White;
            this.Dname.Location = new System.Drawing.Point(198, 75);
            this.Dname.Name = "Dname";
            this.Dname.Size = new System.Drawing.Size(100, 20);
            this.Dname.TabIndex = 50;
            this.Dname.TextChanged += new System.EventHandler(this.firstNameBox_TextChanged);
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.birthDate.Location = new System.Drawing.Point(27, 217);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(115, 13);
            this.birthDate.TabIndex = 49;
            this.birthDate.Text = "Manager Start Date";
            this.birthDate.Click += new System.EventHandler(this.birthDate_Click);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.lastName.Location = new System.Drawing.Point(27, 146);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(80, 13);
            this.lastName.TabIndex = 48;
            this.lastName.Text = "Manager SSN";
            this.lastName.Click += new System.EventHandler(this.lastName_Click);
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.middleName.Location = new System.Drawing.Point(27, 110);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(124, 13);
            this.middleName.TabIndex = 47;
            this.middleName.Text = "Department Number";
            this.middleName.Click += new System.EventHandler(this.middleName_Click);
            // 
            // labbbel
            // 
            this.labbbel.AutoSize = true;
            this.labbbel.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.labbbel.Location = new System.Drawing.Point(27, 75);
            this.labbbel.Name = "labbbel";
            this.labbbel.Size = new System.Drawing.Size(110, 13);
            this.labbbel.TabIndex = 46;
            this.labbbel.Text = "Department Name";
            this.labbbel.Click += new System.EventHandler(this.firstName_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(86, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(281, 25);
            this.Title.TabIndex = 5;
            this.Title.Text = "Insert New Department";
            // 
            // inserttitlepanel
            // 
            this.inserttitlepanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inserttitlepanel.Controls.Add(this.Title);
            this.inserttitlepanel.Location = new System.Drawing.Point(-2, -1);
            this.inserttitlepanel.Name = "inserttitlepanel";
            this.inserttitlepanel.Size = new System.Drawing.Size(426, 52);
            this.inserttitlepanel.TabIndex = 54;
            // 
            // depLocation
            // 
            this.depLocation.Location = new System.Drawing.Point(199, 179);
            this.depLocation.Name = "depLocation";
            this.depLocation.Size = new System.Drawing.Size(100, 20);
            this.depLocation.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.label1.Location = new System.Drawing.Point(25, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Department Location";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(143, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Add ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inserttitlepanel);
            this.Controls.Add(this.dateTimeBox);
            this.Controls.Add(this.manager_ssn);
            this.Controls.Add(this.Dnumber);
            this.Controls.Add(this.Dname);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.labbbel);
            this.Name = "NewDepartment";
            this.Text = "NewDepartment";
            this.inserttitlepanel.ResumeLayout(false);
            this.inserttitlepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeBox;
        private System.Windows.Forms.TextBox manager_ssn;
        private System.Windows.Forms.TextBox Dnumber;
        private System.Windows.Forms.TextBox Dname;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.Label labbbel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel inserttitlepanel;
        private System.Windows.Forms.TextBox depLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}