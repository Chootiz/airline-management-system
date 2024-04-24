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
               
                //show relevant buttons and text boxes
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
               
            }
            else
            {
                this.feedback.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }
       


        
    }
}
