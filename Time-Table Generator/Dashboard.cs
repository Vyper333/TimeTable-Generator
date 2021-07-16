using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Time_Table_Generator
{
    public partial class FacultyDashboard : Form
    {
        public FacultyDashboard()
        {
            InitializeComponent();
        }
        public FacultyDashboard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                button2.Hide();
                button3.Hide();
            }
            else if (user == "Admin")
            {
                btnDisplayTT.Show();
                button2.Show();
                button3.Show();
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();

        }

        private void btnDisplayTT_Click(object sender, EventArgs e)
        {
            
        }
    }
}
