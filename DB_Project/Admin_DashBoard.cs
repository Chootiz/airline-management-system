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
            this.CheckProfile.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckProfile.Checked)
            {
                this.CheckProfile.BackColor = System.Drawing.ColorTranslator.FromHtml("#332084");
                this.CheckProfile.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3359");
                //.BackColor = System.Drawing.ColorTranslator.FromHtml("#332084");
                //.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3359");
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                //first hide everything(hiding all labels at start)
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
                this.label7.Hide();
                this.label8.Hide();
                this.label9.Hide();
               
                this.textBox2.Hide();
                this.textBox3.Hide();
                this.textBox4.Hide();
                this.textBox5.Hide();
                this.textBox6.Hide();
                this.textBox7.Hide();
                this.textBox8.Hide();
                this.textBox9.Hide();

                this.button1.Hide();
                this.button2.Hide();

                this.dataGridView1.Hide();

                //show relevant buttons and text boxes
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
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
                this.CheckProfile.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1D5A");
                this.CheckProfile.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6F6FBC");

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.addEmp.Checked)
            {
                this.addEmp.BackColor = System.Drawing.ColorTranslator.FromHtml("#332084");
                this.addEmp.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3359");
                this.CheckProfile.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                //first hide everything(hiding all labels at start)
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
                this.label7.Hide();
                this.label8.Hide();
                this.label9.Hide();

                this.textBox2.Hide();
                this.textBox3.Hide();
                this.textBox4.Hide();
                this.textBox5.Hide();
                this.textBox6.Hide();
                this.textBox7.Hide();
                this.textBox8.Hide();
                this.textBox9.Hide();

                this.button1.Hide();
                this.button2.Hide();

                this.dataGridView1.Hide();

                //show relevant buttons and text boxes 
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                
                textBox3.Show(); 
                textBox4.Show();
                textBox5.Show(); 
                textBox6.Show();
                textBox7.Show(); 
                textBox8.Show();

                button1.Show();
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
                this.addEmp.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1D5A");
                this.addEmp.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6F6FBC");
            }

            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.manageEmp.Checked)
            {
                this.manageEmp.BackColor = System.Drawing.ColorTranslator.FromHtml("#332084");
                this.manageEmp.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3359");
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                //first hide everything(hiding all labels at start)
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
                this.label7.Hide();
                this.label8.Hide();
                this.label9.Hide();

                this.textBox2.Hide();
                this.textBox3.Hide();
                this.textBox4.Hide();
                this.textBox5.Hide();
                this.textBox6.Hide();
                this.textBox7.Hide();
                this.textBox8.Hide();
                this.textBox9.Hide();

                this.button1.Hide();
                this.button2.Hide();

                this.dataGridView1.Hide();

                //show relevant buttons and text boxes 

                label9.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                textBox8.Show();
                textBox9.Show();

                button1.Show();
                button2.Show();

                dataGridView1.Show();
                label9.Text = "Enter Employee ID:";

                button1.Text = "Submit";
                button2.Text = "Submit";

            }
            else
            {
                this.manageEmp.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1D5A");
                this.manageEmp.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6F6FBC");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.manageFlight.Checked)
            {
                this.manageFlight.BackColor = System.Drawing.ColorTranslator.FromHtml("#332084");
                this.manageFlight.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3359");
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                //first hide everything(hiding all labels at start)
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
                this.label7.Hide();
                this.label8.Hide();
                this.label9.Hide();

                this.textBox2.Hide();
                this.textBox3.Hide();
                this.textBox4.Hide();
                this.textBox5.Hide();
                this.textBox6.Hide();
                this.textBox7.Hide();
                this.textBox8.Hide();
                this.textBox9.Hide();

                this.button1.Hide();
                this.button2.Hide();

                this.dataGridView1.Hide();

                //show relevant buttons and text boxes
                label9.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                textBox8.Show();
                textBox9.Show();

                button1.Show();
                button2.Show();

                dataGridView1.Show();
                label9.Text = "Enter Flight ID:";

                button1.Text = "Submit";
                button2.Text = "Submit";

            }
            else
            {
                this.manageFlight.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1D5A");
                this.manageFlight.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6F6FBC");
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.revenue.Checked)
            {
                this.revenue.BackColor = System.Drawing.ColorTranslator.FromHtml("#332084");
                this.revenue.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3359");
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                // first hide everything (hiding all labels at start)
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();

            }
            else
            {
                this.revenue.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1D5A");
                this.revenue.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6F6FBC");
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.viewFlight.Checked)
            {
                this.viewFlight.BackColor = System.Drawing.ColorTranslator.FromHtml("#332084");
                this.viewFlight.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3359");
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.assignTask.Checked = false;
                this.feedback.Checked = false;
                // first hide everything (hiding all labels at start)
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
            }
            else
            {
                this.viewFlight.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1D5A");
                this.viewFlight.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6F6FBC");
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.assignTask.Checked)
            {
                this.assignTask.BackColor = System.Drawing.ColorTranslator.FromHtml("#332084");
                this.assignTask.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3359");
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.feedback.Checked = false;
                // first hide everything (hiding all labels at start)
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();

            }
            else
            {
                this.assignTask.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1D5A");
                this.assignTask.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6F6FBC");
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.feedback.Checked)
            {
                this.feedback.BackColor = System.Drawing.ColorTranslator.FromHtml("#332084");
                this.feedback.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3359");
                this.CheckProfile.Checked = false;
                this.addEmp.Checked = false;
                this.manageEmp.Checked = false;
                this.manageFlight.Checked = false;
                this.revenue.Checked = false;
                this.viewFlight.Checked = false;
                this.assignTask.Checked = false;
                // first hide everything (hiding all labels at start)
                this.label2.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.label6.Hide();
            }
            else
            {
                this.feedback.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B1D5A");
                this.feedback.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6F6FBC");
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

        private void Admin_DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
