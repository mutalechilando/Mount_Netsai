﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Mount_Netsaiacademy_School_info_sys
{




    public partial class dashboard : Form
    {

        public static string teachername;
        public dashboard()
        {
            InitializeComponent();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StudentRegistration regstud = new StudentRegistration();
            regstud.TopLevel = false;
            regstud.Dock = DockStyle.Fill;
            regstud.Parent = panel1;
            regstud.Size = panel1.Size;
            regstud.Show();

            /*this.IsMdiContainer = true;
            Register_Student regstud = new Register_Student();
            regstud.MdiParent = this;
            regstud.Show();
             * */

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void humanResourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editStudentRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*
            this.IsMdiContainer = true;
            Edit_Student Editstud = new Edit_Student();
            Editstud.MdiParent = this;

            Editstud.Show();
             * */
            panel1.Controls.Clear();
            Edit_Student editstud = new Edit_Student();
            editstud.TopLevel = false;
            editstud.Dock = DockStyle.Fill;
            editstud.Parent = panel1;
            editstud.Size = panel1.Size;
            editstud.Show();

        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            register_employee regemp = new register_employee();
            regemp.TopLevel = false;
            regemp.Dock = DockStyle.Fill;
            regemp.Parent = panel1;
            regemp.Size = panel1.Size;
            regemp.Show();
        }

        private void configurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            add_subjects_race_types_person_types config = new add_subjects_race_types_person_types();
            config.TopLevel = false;
            config.Dock = DockStyle.Fill;
            config.Parent = panel1;
            config.Size = panel1.Size;
            config.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }

        private void createUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                panel1.Controls.Clear();
                CreateUser create = new CreateUser();
                create.TopLevel = false;
                create.Dock = DockStyle.Fill;
                create.Parent = panel1;
                create.Size = panel1.Size;
                create.Show();
            
        }

        private void classManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                panel1.Controls.Clear();
                Class_Managment createClass = new Class_Managment();
                createClass.TopLevel = false;
                createClass.Dock = DockStyle.Fill;
                createClass.Parent = panel1;
                createClass.Size = panel1.Size;
                createClass.Show();
            

        }
     

        private void dashboard_Load(object sender, EventArgs e)
        {
            lblnames.Text = Login.type;
            teachername = lblnames.Text;
            if (DateTime.Now.Hour < 12) 
            {

                lblGreetings.Text = "Good Morning";
            
            }
            else if (DateTime.Now.Hour < 17)
            {

                lblGreetings.Text = "Good Afternoon";
            
            }

            else
            {
                lblGreetings.Text = "Good Evening";
            }
        }

        private void veiwStudeentPerfomanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enterStudentsExamPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StudentPrerfomance Addresults = new StudentPrerfomance();
            Addresults.TopLevel = false;
            Addresults.Dock = DockStyle.Fill;
            Addresults.Parent = panel1;
            Addresults.Size = panel1.Size;
            Addresults.Show();

        }

        private void checkStudentFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Finance StudentFees = new Finance();
            StudentFees.TopLevel = false;
            StudentFees.Dock = DockStyle.Fill;
            StudentFees.Parent = panel1;
            StudentFees.Size = panel1.Size;
            StudentFees.Show();

        }
    }
}
