using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class SignUp : Form
    {
        SignIn parent;
        OracleConnection connect;
        public SignUp(SignIn par, OracleConnection con)
        {
            this.connect = con;
            this.parent = par;
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.textBox1.Hide();
            this.textBox3.Hide();
            this.textBox5.Hide();
            this.button1.Hide();
            this.button3.Hide();
            this.button5.Hide();
            this.button7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.button1.Show();
                this.button3.Show();
                this.button5.Show();
                this.button7.Show();
                this.button6.Hide();
                this.button4.Hide();
                this.button8.Hide();
                this.textBox6.Hide();
                this.textBox4.Hide();
                this.textBox2.Hide();
                this.textBox1.Show();
                this.textBox3.Show();
                this.textBox5.Show();
                this.label5.Hide();
                this.label1.Text = "E-Mail";
                this.label2.Text = "Password";
                this.label4.Text = "Confirm Password";
                this.checkBox1.Text = "Previous";
            }
            else
            {
                this.button1.Hide();
                this.button3.Hide();
                this.button5.Hide();
                this.button7.Hide();
                this.button6.Show();
                this.button4.Show();
                this.button8.Show();
                this.textBox6.Show();
                this.textBox4.Show();
                this.textBox2.Show();
                this.textBox1.Hide();
                this.textBox3.Hide();
                this.textBox5.Hide();
                this.label5.Show();
                this.label1.Text = "Name";
                this.label2.Text = "CNIC";
                this.label4.Text = "Phone No.";
                this.checkBox1.Text = "Next";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string str = this.textBox4.Text;
            if (str == "")
            {
                this.label5.Text = "Please use the CNIC Format 12345-1234567-8";
                return;
            }
            if (str.Length != 15) this.label5.Text = "           Invalid CNIC Format\nPlease use the CNIC Format 12345-1234567-8";
            else
            {
                this.label5.Text = "";
                for (int i = 0; i < 15; i++) if (str[i] != '-' && (str[i] < '0' || str[i] > '9')) this.label5.Text = "           Invalid CNIC Format\nPlease use the CNIC Format 12345-1234567-8";
                if (str[5] != '-' || str[13] != '-') this.label5.Text = "           Invalid CNIC Format\nPlease use the CNIC Format 12345-1234567-8";

            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

//Textbox 6 ->> name
//Textbox 4 ->> CNIC
//Textbox 2 ->> Phone No

//Textbox 5 ->> EMail
//Textbox 1 ->> password
//Textbox 3 ->> confirm password