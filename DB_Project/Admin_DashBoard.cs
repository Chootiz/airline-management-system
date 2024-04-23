using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.radioButton1.BackColor = System.Drawing.SystemColors.Highlight;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
                this.radioButton6.Checked = false;
                this.radioButton7.Checked = false;
                this.radioButton8.Checked = false;
                this.radioButton9.Checked = false;
                //show relevant buttons and text boxes
            }
            else
            {
                this.radioButton1.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.radioButton2.BackColor = System.Drawing.SystemColors.Highlight;
                this.radioButton1.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
                this.radioButton6.Checked = false;
                this.radioButton7.Checked = false;
                this.radioButton8.Checked = false;
                this.radioButton9.Checked = false;
            }
            else
            {
                this.radioButton2.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                this.radioButton3.BackColor = System.Drawing.SystemColors.Highlight;
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
                this.radioButton6.Checked = false;
                this.radioButton7.Checked = false;
                this.radioButton8.Checked = false;
                this.radioButton9.Checked = false;
            }
            else
            {
                this.radioButton3.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked)
            {
                this.radioButton4.BackColor = System.Drawing.SystemColors.Highlight;
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton5.Checked = false;
                this.radioButton6.Checked = false;
                this.radioButton7.Checked = false;
                this.radioButton8.Checked = false;
                this.radioButton9.Checked = false;
            }
            else
            {
                this.radioButton4.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton5.Checked)
            {
                this.radioButton5.BackColor = System.Drawing.SystemColors.Highlight;
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton6.Checked = false;
                this.radioButton7.Checked = false;
                this.radioButton8.Checked = false;
                this.radioButton9.Checked = false;
            }
            else
            {
                this.radioButton5.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton6.Checked)
            {
                this.radioButton6.BackColor = System.Drawing.SystemColors.Highlight;
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
            
                this.radioButton7.Checked = false;
                this.radioButton8.Checked = false;
                this.radioButton9.Checked = false;
            }
            else
            {
                this.radioButton6.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton7.Checked)
            {
                this.radioButton7.BackColor = System.Drawing.SystemColors.Highlight;
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
                this.radioButton6.Checked = false;
                this.radioButton8.Checked = false;
                this.radioButton9.Checked = false;
            }
            else
            {
                this.radioButton7.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton8.Checked)
            {
                this.radioButton8.BackColor = System.Drawing.SystemColors.Highlight;
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
                this.radioButton6.Checked = false;
                this.radioButton7.Checked = false;
                this.radioButton9.Checked = false;
            }
            else
            {
                this.radioButton8.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton9.Checked)
            {
                this.radioButton9.BackColor = System.Drawing.SystemColors.Highlight;
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
                this.radioButton6.Checked = false;
                this.radioButton7.Checked = false;
                this.radioButton8.Checked = false;
            }
            else
            {
                this.radioButton9.BackColor = System.Drawing.SystemColors.ControlDark;
            }
        }


        
    }
}
