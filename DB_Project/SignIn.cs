using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DB_Project
{
    public partial class SignIn : Form
    {
        OracleConnection connect;
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/xe;USER ID=AIRLINE;PASSWORD=db_on_air";
            connect = new OracleConnection(conStr);
            this.radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchAtt = "", msg = "";
            if (this.radioButton1.Checked) searchAtt = "CNIC";
            if (this.radioButton2.Checked) searchAtt = "EMAIL";
            if (this.radioButton3.Checked) searchAtt = "USERID";
            if (this.radioButton1.Checked) msg = "CNIC";
            if (this.radioButton2.Checked) msg = "E-Mail";
            if (this.radioButton3.Checked) msg = "User ID";
            connect.Open();
            OracleCommand search = connect.CreateCommand();
            search.CommandText = "SELECT * FROM PASSENGER WHERE " + searchAtt + "=:criteria";
            search.Parameters.Add(":criteria", OracleDbType.Varchar2).Value = textBox1.Text;
            OracleDataReader reader = search.ExecuteReader();
           if (reader.Read())
            {
                if (textBox2.Text == reader.GetString(reader.GetOrdinal("PASSWORD")))
                {
                    //Passenger Login
                }
                else MessageBox.Show("Incorrect Password Entered\nPlease Try again", "Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                search.CommandText = "SELECT * FROM PASSENGER WHERE " + searchAtt + "=:criteria";
                reader = search.ExecuteReader();
                if (reader.Read())
                {
                    if (textBox2.Text == reader.GetString(reader.GetOrdinal("PASSWORD")))
                    {
                        //Employee Login
                    }
                    else MessageBox.Show("Incorrect Password Entered\nPlease Try again", "Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    search.CommandText = "SELECT * FROM PASSENGER WHERE " + searchAtt + "=:criteria";
                    reader = search.ExecuteReader();
                    if (reader.Read())
                    {
                        if (textBox2.Text == reader.GetString(reader.GetOrdinal("PASSWORD")))
                        {
                            //Admin Login
                        }
                        else MessageBox.Show("Incorrect Password Entered\nPlease Try again", "Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("No user was found against the "+ msg +" Entered.\nPlease check your entered "+ msg +" and try again.", "No Account Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            connect.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = this.textBox1.Text;
            if(str=="") this.label4.Text = "Please use the CNIC Format 12345-1234567-8";
            int limit = 150;
            if (this.radioButton1.Checked) limit = 15;
            if (this.radioButton2.Checked) limit = 25;
            if (str.Length > limit)
            {
                int cursorPos = textBox1.SelectionStart;
                string str2 = "";
                for (int i = 0; i < str.Length - 1;i++) str2 += str[i];
                this.textBox1.Text = str2;
                textBox1.SelectionStart = Math.Min(cursorPos, textBox1.Text.Length);
                return;
            }
            if (str.Length != 15) this.label4.Text = "           Invalid CNIC Format\nPlease use the CNIC Format 12345-1234567-8";
            else
            {
                this.label4.Text = "";
                for (int i = 0; i < 15; i++) if (str[i] != '-' && (str[i]<'0' || str[i] > '9')) this.label4.Text = "           Invalid CNIC Format\nPlease use the CNIC Format 12345-1234567-8";
                if (str[5] != '-' || str[13] != '-') this.label4.Text = "           Invalid CNIC Format\nPlease use the CNIC Format 12345-1234567-8";

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2D1493");
                this.radioButton1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#4761F3");
                this.label1.Text = "Enter CNIC";
                this.label4.Show();
            }
            else
            {
                this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
                this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.BackColor = System.Drawing.ColorTranslator.FromHtml("#2D1493");
                this.radioButton3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#4761F3");
                this.label1.Text = "Enter User ID";
                this.label4.Hide();
            }
            else
            {
                this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
                this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.radioButton1.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton2.BackColor = System.Drawing.ColorTranslator.FromHtml("#2D1493");
                this.radioButton2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#4761F3");
                this.label1.Text = "Enter E-Mail Address";
                this.label4.Hide();
            }
            else
            {
                this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
                this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
