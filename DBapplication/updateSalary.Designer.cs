
namespace DBapplication
{
    partial class updateSalary
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
            this.button1 = new System.Windows.Forms.Button();
            this.inserttitlepanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.newSalary = new System.Windows.Forms.TextBox();
            this.empSSN = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.Label();
            this.labbbel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inserttitlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(86, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inserttitlepanel
            // 
            this.inserttitlepanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inserttitlepanel.Controls.Add(this.Title);
            this.inserttitlepanel.Location = new System.Drawing.Point(0, 0);
            this.inserttitlepanel.Name = "inserttitlepanel";
            this.inserttitlepanel.Size = new System.Drawing.Size(426, 52);
            this.inserttitlepanel.TabIndex = 62;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(79, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(171, 25);
            this.Title.TabIndex = 5;
            this.Title.Text = "Update Salary";
            // 
            // newSalary
            // 
            this.newSalary.Location = new System.Drawing.Point(174, 129);
            this.newSalary.Name = "newSalary";
            this.newSalary.Size = new System.Drawing.Size(100, 20);
            this.newSalary.TabIndex = 61;
            // 
            // empSSN
            // 
            this.empSSN.BackColor = System.Drawing.Color.White;
            this.empSSN.Location = new System.Drawing.Point(174, 80);
            this.empSSN.Name = "empSSN";
            this.empSSN.Size = new System.Drawing.Size(100, 20);
            this.empSSN.TabIndex = 60;
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.middleName.Location = new System.Drawing.Point(29, 129);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(73, 13);
            this.middleName.TabIndex = 59;
            this.middleName.Text = "New Salary";
            // 
            // labbbel
            // 
            this.labbbel.AutoSize = true;
            this.labbbel.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.labbbel.Location = new System.Drawing.Point(29, 80);
            this.labbbel.Name = "labbbel";
            this.labbbel.Size = new System.Drawing.Size(90, 13);
            this.labbbel.TabIndex = 58;
            this.labbbel.Text = "Employee SSN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(171, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Enter Correct Value";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(171, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Enter Correct Value";
            this.label2.Visible = false;
            // 
            // updateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inserttitlepanel);
            this.Controls.Add(this.newSalary);
            this.Controls.Add(this.empSSN);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.labbbel);
            this.Name = "updateSalary";
            this.Text = "updateSalary";
            this.inserttitlepanel.ResumeLayout(false);
            this.inserttitlepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel inserttitlepanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox newSalary;
        private System.Windows.Forms.TextBox empSSN;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.Label labbbel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}