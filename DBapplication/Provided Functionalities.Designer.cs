namespace DBapplication
{
    partial class Provided_Functionalities
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.inserttitlepanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.inserttitlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button2.Location = new System.Drawing.Point(12, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "View All Employees";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ViewEmployeesButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button3.Location = new System.Drawing.Point(13, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Retrieve Projects";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ViewProjectsButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button4.Location = new System.Drawing.Point(12, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Department";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button5.Location = new System.Drawing.Point(13, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Get Employees";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // inserttitlepanel
            // 
            this.inserttitlepanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inserttitlepanel.Controls.Add(this.Title);
            this.inserttitlepanel.Location = new System.Drawing.Point(-118, 0);
            this.inserttitlepanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inserttitlepanel.Name = "inserttitlepanel";
            this.inserttitlepanel.Size = new System.Drawing.Size(575, 52);
            this.inserttitlepanel.TabIndex = 57;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(158, 13);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(73, 25);
            this.Title.TabIndex = 6;
            this.Title.Text = "Menu";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button6.Location = new System.Drawing.Point(12, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 23);
            this.button6.TabIndex = 58;
            this.button6.Text = "Update Salary";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.button7.Location = new System.Drawing.Point(12, 320);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 23);
            this.button7.TabIndex = 59;
            this.button7.Text = "Get Address";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Provided_Functionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 378);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.inserttitlepanel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Provided_Functionalities";
            this.Text = "Provided_Functionalities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Provided_Functionalities_FormClosed);
            this.inserttitlepanel.ResumeLayout(false);
            this.inserttitlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel inserttitlepanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}