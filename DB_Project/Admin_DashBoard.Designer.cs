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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Profile ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(574, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(574, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(574, 176);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(574, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(574, 226);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(574, 252);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(574, 278);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "label8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 320);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Admin_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}