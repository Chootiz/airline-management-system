namespace DB_Project
{
    partial class Admin_DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_DashBoard));
            this.CheckProfile = new System.Windows.Forms.RadioButton();
            this.addEmp = new System.Windows.Forms.RadioButton();
            this.manageEmp = new System.Windows.Forms.RadioButton();
            this.manageFlight = new System.Windows.Forms.RadioButton();
            this.revenue = new System.Windows.Forms.RadioButton();
            this.viewFlight = new System.Windows.Forms.RadioButton();
            this.assignTask = new System.Windows.Forms.RadioButton();
            this.feedback = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckProfile
            // 
            this.CheckProfile.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckProfile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CheckProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckProfile.Location = new System.Drawing.Point(12, 10);
            this.CheckProfile.Name = "CheckProfile";
            this.CheckProfile.Size = new System.Drawing.Size(145, 51);
            this.CheckProfile.TabIndex = 0;
            this.CheckProfile.Text = "\n Check Profile\n ";
            this.CheckProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckProfile.UseVisualStyleBackColor = false;
            this.CheckProfile.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // addEmp
            // 
            this.addEmp.Appearance = System.Windows.Forms.Appearance.Button;
            this.addEmp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addEmp.Location = new System.Drawing.Point(12, 60);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(145, 51);
            this.addEmp.TabIndex = 1;
            this.addEmp.Text = "\nAdd Employee\n ";
            this.addEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addEmp.UseVisualStyleBackColor = false;
            this.addEmp.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // manageEmp
            // 
            this.manageEmp.Appearance = System.Windows.Forms.Appearance.Button;
            this.manageEmp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.manageEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageEmp.Location = new System.Drawing.Point(12, 110);
            this.manageEmp.Name = "manageEmp";
            this.manageEmp.Size = new System.Drawing.Size(145, 51);
            this.manageEmp.TabIndex = 2;
            this.manageEmp.Text = "\n   Manage Employee\n ";
            this.manageEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageEmp.UseVisualStyleBackColor = false;
            this.manageEmp.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // manageFlight
            // 
            this.manageFlight.Appearance = System.Windows.Forms.Appearance.Button;
            this.manageFlight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.manageFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageFlight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageFlight.Location = new System.Drawing.Point(12, 160);
            this.manageFlight.Name = "manageFlight";
            this.manageFlight.Size = new System.Drawing.Size(145, 51);
            this.manageFlight.TabIndex = 3;
            this.manageFlight.Text = "\n   Manage Flight Schedule \n ";
            this.manageFlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageFlight.UseVisualStyleBackColor = false;
            this.manageFlight.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // revenue
            // 
            this.revenue.Appearance = System.Windows.Forms.Appearance.Button;
            this.revenue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.revenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revenue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.revenue.Location = new System.Drawing.Point(12, 210);
            this.revenue.Name = "revenue";
            this.revenue.Size = new System.Drawing.Size(145, 51);
            this.revenue.TabIndex = 4;
            this.revenue.Text = "\n   Revenue  \n ";
            this.revenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.revenue.UseVisualStyleBackColor = false;
            this.revenue.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // viewFlight
            // 
            this.viewFlight.Appearance = System.Windows.Forms.Appearance.Button;
            this.viewFlight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.viewFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewFlight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewFlight.Location = new System.Drawing.Point(12, 260);
            this.viewFlight.Name = "viewFlight";
            this.viewFlight.Size = new System.Drawing.Size(145, 51);
            this.viewFlight.TabIndex = 5;
            this.viewFlight.Text = "\n   View Flights Status   \n ";
            this.viewFlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewFlight.UseVisualStyleBackColor = false;
            this.viewFlight.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // assignTask
            // 
            this.assignTask.Appearance = System.Windows.Forms.Appearance.Button;
            this.assignTask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.assignTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignTask.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignTask.Location = new System.Drawing.Point(12, 310);
            this.assignTask.Name = "assignTask";
            this.assignTask.Size = new System.Drawing.Size(145, 51);
            this.assignTask.TabIndex = 6;
            this.assignTask.Text = "\n   Assign Task   \n ";
            this.assignTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.assignTask.UseVisualStyleBackColor = false;
            this.assignTask.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // feedback
            // 
            this.feedback.Appearance = System.Windows.Forms.Appearance.Button;
            this.feedback.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.feedback.Location = new System.Drawing.Point(12, 360);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(145, 51);
            this.feedback.TabIndex = 7;
            this.feedback.Text = "\n   View Feedback   \n ";
            this.feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.feedback.UseVisualStyleBackColor = false;
            this.feedback.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Location = new System.Drawing.Point(163, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(660, 400);
            this.textBox1.TabIndex = 8;
            // 
            // Admin_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 424);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.assignTask);
            this.Controls.Add(this.viewFlight);
            this.Controls.Add(this.revenue);
            this.Controls.Add(this.manageFlight);
            this.Controls.Add(this.manageEmp);
            this.Controls.Add(this.addEmp);
            this.Controls.Add(this.CheckProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_DashBoard";
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Admin_DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CheckProfile;
        private System.Windows.Forms.RadioButton addEmp;
        private System.Windows.Forms.RadioButton manageEmp;
        private System.Windows.Forms.RadioButton manageFlight;
        private System.Windows.Forms.RadioButton revenue;
        private System.Windows.Forms.RadioButton viewFlight;
        private System.Windows.Forms.RadioButton assignTask;
        private System.Windows.Forms.RadioButton feedback;
        private System.Windows.Forms.TextBox textBox1;
    }
}