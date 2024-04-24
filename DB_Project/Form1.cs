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
    public partial class Form1 : Form
    {
        OracleConnection connect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/xe;USER ID=AIRLINE;PASSWORD=db_on_air";
            connect = new OracleConnection(conStr);
            this.label4.Text = "Please use the CNIC Format 12345-1234567-8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text=="i have the power")
            {
                //admin login
            }
            connect.Open();
            OracleCommand search = connect.CreateCommand();
            search.CommandText = "SELECT * FROM PASSENGERS WHERE CNIC=" + textBox1.Text;
            search.CommandType = CommandType.Text;
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
                search.CommandText = "SELECT * FROM EMPLOYEE WHERE CNIC=" + textBox1.Text;
                reader = search.ExecuteReader();
                if (reader.Read())
                {
                    if (textBox2.Text == reader.GetString(reader.GetOrdinal("PASSWORD")))
                    {
                        //Employee Login
                    }
                    else MessageBox.Show("Incorrect Password Entered\nPlease Try again", "Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("No user was found against the CNIC Entered\nPlease check your entered CNIC and try again", "No Account Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            connect.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = this.textBox1.Text;
            if (str.Length != 15)  this.label4.Text = "Invalid CNIC Format\nPlease use the CNIC Format 12345-1234567-8";
            else
            {
                this.label4.Text = "Please use the CNIC Format 12345-1234567-8";
                for (int i = 0; i < 15; i++) if (str[i] != '-' && (str[i]<'0' || str[i] > '9')) this.label4.Text = "Invalid CNIC Format\nPlease use the CNIC Format 12345-1234567-8";
                if (str[5] != '-' && str[13] != '-') this.label4.Text = "Invalid CNIC Format\nPlease use the CNIC Format 12345-1234567-8";
            }
        }
    }
}
