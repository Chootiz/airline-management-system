using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Admin_DashBoard : Form
    {
        public Admin_DashBoard()
        {
            InitializeComponent();
        }

        private void Admin_DashBoard_Load(object sender, EventArgs e)
        {
            this.CheckProfile.Checked = true; ;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckProfile.Checked)
            {
                this.CheckProfile.BackColor = System.Drawing.SystemColors.Highlight;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                //first hide everything(hiding all labels at start)
                this.label1.Hide();
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
                this.label7.Hide();
                this.label8.Hide();

               
                this.textBox2.Hide();
                this.textBox3.Hide();
                this.textBox4.Hide();
                this.textBox5.Hide();
                this.textBox6.Hide();
                this.textBox7.Hide();
                this.textBox8.Hide();
                this.button1.Hide();
                this.dataGridView1.Hide();

                //show relevant buttons and text boxes
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label1.Text = "Profile";
                label2.Text = "UserId:";
                //take user id from DB and concat with label2
                label3.Text = "Name:";
                //take Name from DB and concat with label3
                label4.Text = "CNIC:";
                //take CNIC from DB and concat with label4
                label5.Text = "Email:";
                //take Email from DB and concat with label5
                label6.Text = "Phone Number:";
                //take phoneNo from DB and concat with label6
                 
            }
            else
            {
                this.CheckProfile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.addEmp.Checked)
            {
                this.addEmp.BackColor = System.Drawing.SystemColors.Highlight;
                this.CheckProfile.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                //first hide everything(hiding all labels at start)
                this.label1.Hide();
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
                this.label7.Hide();
                this.label8.Hide();

                
                this.textBox2.Hide();
                this.textBox3.Hide();
                this.textBox4.Hide();
                this.textBox5.Hide();
                this.textBox6.Hide();
                this.textBox7.Hide();
                this.textBox8.Hide();
                this.button1.Hide();
                this.dataGridView1.Hide();

                //show relevant buttons and text boxes 
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                
                textBox2.Show();
                textBox3.Show(); 
                textBox4.Show();
                textBox5.Show(); 
                textBox6.Show();
                textBox7.Show(); 
                textBox8.Show();

                button1.Show();
                label1.Text = "Add Employee Details";
                label2.Text = "UserId:";
                //take user id from DB and concat with label2
                label3.Text = "Name:";
                //take Name from DB and concat with label3
                label4.Text = "CNIC:";
                //take CNIC from DB and concat with label4
                label5.Text = "Email:";
                //take Email from DB and concat with label5
                label6.Text = "Phone Number:";
                //take phoneNo from DB and concat with label6
                label7.Text = "Password:";
                label8.Text = "Confirm Password:";

                button1.Text = "Submit";

                
            }
            else
            {
                this.addEmp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }

            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.manageEmp.Checked)
            {
                this.manageEmp.BackColor = System.Drawing.SystemColors.Highlight;
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                //first hide everything(hiding all labels at start)
                this.label1.Hide();
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
                this.label7.Hide();
                this.label8.Hide();


                this.textBox2.Hide();
                this.textBox3.Hide();
                this.textBox4.Hide();
                this.textBox5.Hide();
                this.textBox6.Hide();
                this.textBox7.Hide();
                this.textBox8.Hide();
                this.button1.Hide();
                this.dataGridView1.Hide();

                //show relevant buttons and text boxes 

                label1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                textBox8.Show();
                button1.Show();
                dataGridView1.Show();
                label1.Text =" UPDATE Employee Details";
                

                button1.Text = "Submit";

            }
            else
            {
                this.manageEmp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.manageFlight.Checked)
            {
                this.manageFlight.BackColor = System.Drawing.SystemColors.Highlight;
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                // first hide everything (hiding all labels at start)
                this.label1.Hide();
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();

            }
            else
            {
                this.manageFlight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.revenue.Checked)
            {
                this.revenue.BackColor = System.Drawing.SystemColors.Highlight;
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                // first hide everything (hiding all labels at start)
                this.label1.Hide();
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();

            }
            else
            {
                this.revenue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.viewFlight.Checked)
            {
                this.viewFlight.BackColor = System.Drawing.SystemColors.Highlight;
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                // first hide everything (hiding all labels at start)
                this.label1.Hide();
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
            }
            else
            {
                this.viewFlight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.assignTask.Checked)
            {
                this.assignTask.BackColor = System.Drawing.SystemColors.Highlight;
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.feedback.Checked = false;
                // first hide everything (hiding all labels at start)
                this.label1.Hide();
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();

            }
            else
            {
                this.assignTask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.feedback.Checked)
            {
                this.feedback.BackColor = System.Drawing.SystemColors.Highlight;
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                // first hide everything (hiding all labels at start)
                this.label1.Hide();
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
            }
            else
            {
                this.feedback.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
