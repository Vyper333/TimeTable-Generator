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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "1234")
            {
                FacultyDashboard ds = new FacultyDashboard("Admin");
                ds.Show();
                this.Hide();
            }
        }

      
    }
}
