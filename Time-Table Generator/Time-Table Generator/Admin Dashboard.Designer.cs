namespace Time_Table_Generator
{
    partial class Admin_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGenerateTT = new System.Windows.Forms.Button();
            this.btnAddTr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnGenerateTT);
            this.panel2.Controls.Add(this.btnAddTr);
            this.panel2.Location = new System.Drawing.Point(17, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 483);
            this.panel2.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.LinkColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(57, 444);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(62, 20);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.TabStop = true;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogOut_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.FlatAppearance.BorderSize = 15;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(22, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Display TimeTable";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnGenerateTT
            // 
            this.btnGenerateTT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerateTT.FlatAppearance.BorderSize = 15;
            this.btnGenerateTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateTT.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTT.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateTT.Location = new System.Drawing.Point(22, 136);
            this.btnGenerateTT.Name = "btnGenerateTT";
            this.btnGenerateTT.Size = new System.Drawing.Size(151, 55);
            this.btnGenerateTT.TabIndex = 1;
            this.btnGenerateTT.Text = "Generate Timetable";
            this.btnGenerateTT.UseVisualStyleBackColor = false;
            this.btnGenerateTT.Click += new System.EventHandler(this.btnGenerateTT_Click);
            // 
            // btnAddTr
            // 
            this.btnAddTr.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddTr.FlatAppearance.BorderSize = 15;
            this.btnAddTr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTr.ForeColor = System.Drawing.Color.Black;
            this.btnAddTr.Location = new System.Drawing.Point(22, 45);
            this.btnAddTr.Name = "btnAddTr";
            this.btnAddTr.Size = new System.Drawing.Size(151, 55);
            this.btnAddTr.TabIndex = 0;
            this.btnAddTr.Text = "Add teacher";
            this.btnAddTr.UseVisualStyleBackColor = false;
            this.btnAddTr.Click += new System.EventHandler(this.btnAddTr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(216, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 483);
            this.panel1.TabIndex = 2;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(854, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGenerateTT;
        private System.Windows.Forms.Button btnAddTr;
        private System.Windows.Forms.Panel panel1;
    }
}