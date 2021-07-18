using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Table_Generator
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }
        public Admin_Dashboard(String user)
        {
            InitializeComponent();
             if (user == "Admin")
            {
                btnAddTr.Show();
                btnGenerateTT.Show();
                button3.Show();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Login fm = new Admin_Login();
            this.Hide();
            fm.Show();
        }

        private void btnAddTr_Click(object sender, EventArgs e)
        {
            AddTeacher at = new AddTeacher();
            at.Show();
        }

        private void btnGenerateTT_Click(object sender, EventArgs e)
        {
            GenerateTT gtt = new GenerateTT();
            gtt.Show();
        }
    }
}
