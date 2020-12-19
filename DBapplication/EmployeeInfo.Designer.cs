
namespace DBapplication
{
    partial class EmployeeInfo
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
            this.inserttitlepanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Dname = new System.Windows.Forms.TextBox();
            this.labbbel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inserttitlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inserttitlepanel
            // 
            this.inserttitlepanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inserttitlepanel.Controls.Add(this.Title);
            this.inserttitlepanel.Location = new System.Drawing.Point(0, 0);
            this.inserttitlepanel.Name = "inserttitlepanel";
            this.inserttitlepanel.Size = new System.Drawing.Size(426, 52);
            this.inserttitlepanel.TabIndex = 57;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(86, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(252, 25);
            this.Title.TabIndex = 5;
            this.Title.Text = "Get SSN And Address";
            // 
            // Dname
            // 
            this.Dname.BackColor = System.Drawing.Color.White;
            this.Dname.Location = new System.Drawing.Point(301, 74);
            this.Dname.Name = "Dname";
            this.Dname.Size = new System.Drawing.Size(100, 20);
            this.Dname.TabIndex = 56;
            // 
            // labbbel
            // 
            this.labbbel.AutoSize = true;
            this.labbbel.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.labbbel.Location = new System.Drawing.Point(29, 76);
            this.labbbel.Name = "labbbel";
            this.labbbel.Size = new System.Drawing.Size(266, 13);
            this.labbbel.TabIndex = 55;
            this.labbbel.Text = "For Employees That Their Salary is Less Than";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 139);
            this.dataGridView1.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(148, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Excute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(247, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "please enter correct value";
            this.label4.Visible = false;
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inserttitlepanel);
            this.Controls.Add(this.Dname);
            this.Controls.Add(this.labbbel);
            this.Name = "EmployeeInfo";
            this.Text = "EmployeeInfo";
            this.inserttitlepanel.ResumeLayout(false);
            this.inserttitlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel inserttitlepanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Dname;
        private System.Windows.Forms.Label labbbel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}