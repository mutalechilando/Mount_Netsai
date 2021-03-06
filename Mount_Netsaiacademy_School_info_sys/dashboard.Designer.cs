﻿namespace Mount_Netsaiacademy_School_info_sys
{
    partial class dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPerfomanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterStudentsExamPerformanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiwStudeentPerfomanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsFeesStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStudentFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanResourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEployeeRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblnames = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStudentToolStripMenuItem,
            this.studentPerfomanceToolStripMenuItem,
            this.studentsFeesStatusToolStripMenuItem,
            this.humanResourseToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1600, 93);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStudentToolStripMenuItem,
            this.editStudentRecordsToolStripMenuItem});
            this.manageStudentToolStripMenuItem.Image = global::Mount_Netsaiacademy_School_info_sys.Properties.Resources.icon_student;
            this.manageStudentToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.manageStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageStudentToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(106, 89);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            this.manageStudentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manageStudentToolStripMenuItem.Click += new System.EventHandler(this.manageStudentToolStripMenuItem_Click);
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerStudentToolStripMenuItem.Image = global::Mount_Netsaiacademy_School_info_sys.Properties.Resources.images;
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.registerStudentToolStripMenuItem.Text = "Register_New_Student";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // editStudentRecordsToolStripMenuItem
            // 
            this.editStudentRecordsToolStripMenuItem.Image = global::Mount_Netsaiacademy_School_info_sys.Properties.Resources.Student_3_icon2;
            this.editStudentRecordsToolStripMenuItem.Name = "editStudentRecordsToolStripMenuItem";
            this.editStudentRecordsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.editStudentRecordsToolStripMenuItem.Text = "Edit_Student_Records";
            this.editStudentRecordsToolStripMenuItem.Click += new System.EventHandler(this.editStudentRecordsToolStripMenuItem_Click);
            // 
            // studentPerfomanceToolStripMenuItem
            // 
            this.studentPerfomanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterStudentsExamPerformanceToolStripMenuItem,
            this.veiwStudeentPerfomanceToolStripMenuItem});
            this.studentPerfomanceToolStripMenuItem.Image = global::Mount_Netsaiacademy_School_info_sys.Properties.Resources.Performance;
            this.studentPerfomanceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentPerfomanceToolStripMenuItem.Name = "studentPerfomanceToolStripMenuItem";
            this.studentPerfomanceToolStripMenuItem.Size = new System.Drawing.Size(127, 89);
            this.studentPerfomanceToolStripMenuItem.Text = "Student Perfomance";
            this.studentPerfomanceToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // enterStudentsExamPerformanceToolStripMenuItem
            // 
            this.enterStudentsExamPerformanceToolStripMenuItem.Name = "enterStudentsExamPerformanceToolStripMenuItem";
            this.enterStudentsExamPerformanceToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.enterStudentsExamPerformanceToolStripMenuItem.Text = "Enter Students Exam Performance ";
            this.enterStudentsExamPerformanceToolStripMenuItem.Click += new System.EventHandler(this.enterStudentsExamPerformanceToolStripMenuItem_Click);
            // 
            // veiwStudeentPerfomanceToolStripMenuItem
            // 
            this.veiwStudeentPerfomanceToolStripMenuItem.Name = "veiwStudeentPerfomanceToolStripMenuItem";
            this.veiwStudeentPerfomanceToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.veiwStudeentPerfomanceToolStripMenuItem.Text = "Veiw Student Perfomance";
            this.veiwStudeentPerfomanceToolStripMenuItem.Click += new System.EventHandler(this.veiwStudeentPerfomanceToolStripMenuItem_Click);
            // 
            // studentsFeesStatusToolStripMenuItem
            // 
            this.studentsFeesStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkStudentFeesToolStripMenuItem});
            this.studentsFeesStatusToolStripMenuItem.Image = global::Mount_Netsaiacademy_School_info_sys.Properties.Resources._12991670401459277586supervisor;
            this.studentsFeesStatusToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentsFeesStatusToolStripMenuItem.Name = "studentsFeesStatusToolStripMenuItem";
            this.studentsFeesStatusToolStripMenuItem.Size = new System.Drawing.Size(183, 89);
            this.studentsFeesStatusToolStripMenuItem.Text = "Students Payment Managment";
            this.studentsFeesStatusToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // checkStudentFeesToolStripMenuItem
            // 
            this.checkStudentFeesToolStripMenuItem.Name = "checkStudentFeesToolStripMenuItem";
            this.checkStudentFeesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.checkStudentFeesToolStripMenuItem.Text = "Check Student Fees";
            this.checkStudentFeesToolStripMenuItem.Click += new System.EventHandler(this.checkStudentFeesToolStripMenuItem_Click);
            // 
            // humanResourseToolStripMenuItem
            // 
            this.humanResourseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeManagmentToolStripMenuItem,
            this.leaveApplicationToolStripMenuItem});
            this.humanResourseToolStripMenuItem.Image = global::Mount_Netsaiacademy_School_info_sys.Properties.Resources.download;
            this.humanResourseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.humanResourseToolStripMenuItem.Name = "humanResourseToolStripMenuItem";
            this.humanResourseToolStripMenuItem.Size = new System.Drawing.Size(109, 89);
            this.humanResourseToolStripMenuItem.Text = "Human Resourse";
            this.humanResourseToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.humanResourseToolStripMenuItem.Click += new System.EventHandler(this.humanResourseToolStripMenuItem_Click);
            // 
            // employeeManagmentToolStripMenuItem
            // 
            this.employeeManagmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerEmployeeToolStripMenuItem,
            this.editEployeeRecordToolStripMenuItem});
            this.employeeManagmentToolStripMenuItem.Name = "employeeManagmentToolStripMenuItem";
            this.employeeManagmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.employeeManagmentToolStripMenuItem.Text = "Employee Managment";
            // 
            // registerEmployeeToolStripMenuItem
            // 
            this.registerEmployeeToolStripMenuItem.Name = "registerEmployeeToolStripMenuItem";
            this.registerEmployeeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registerEmployeeToolStripMenuItem.Text = "Register Employee";
            this.registerEmployeeToolStripMenuItem.Click += new System.EventHandler(this.registerEmployeeToolStripMenuItem_Click);
            // 
            // editEployeeRecordToolStripMenuItem
            // 
            this.editEployeeRecordToolStripMenuItem.Name = "editEployeeRecordToolStripMenuItem";
            this.editEployeeRecordToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editEployeeRecordToolStripMenuItem.Text = "Edit Eployee Record";
            // 
            // leaveApplicationToolStripMenuItem
            // 
            this.leaveApplicationToolStripMenuItem.Name = "leaveApplicationToolStripMenuItem";
            this.leaveApplicationToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.leaveApplicationToolStripMenuItem.Text = "Leave Application";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUsersToolStripMenuItem,
            this.configurationsToolStripMenuItem,
            this.classManagementToolStripMenuItem});
            this.administratorToolStripMenuItem.Image = global::Mount_Netsaiacademy_School_info_sys.Properties.Resources._13_setting_configure_repair_support_optimization_google_512;
            this.administratorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 89);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // createUsersToolStripMenuItem
            // 
            this.createUsersToolStripMenuItem.Name = "createUsersToolStripMenuItem";
            this.createUsersToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.createUsersToolStripMenuItem.Text = "Create_Users";
            this.createUsersToolStripMenuItem.Click += new System.EventHandler(this.createUsersToolStripMenuItem_Click);
            // 
            // configurationsToolStripMenuItem
            // 
            this.configurationsToolStripMenuItem.Name = "configurationsToolStripMenuItem";
            this.configurationsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.configurationsToolStripMenuItem.Text = "Configurations";
            this.configurationsToolStripMenuItem.Click += new System.EventHandler(this.configurationsToolStripMenuItem_Click);
            // 
            // classManagementToolStripMenuItem
            // 
            this.classManagementToolStripMenuItem.Name = "classManagementToolStripMenuItem";
            this.classManagementToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.classManagementToolStripMenuItem.Text = "Class Management";
            this.classManagementToolStripMenuItem.Click += new System.EventHandler(this.classManagementToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1879, 805);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Image = global::Mount_Netsaiacademy_School_info_sys.Properties.Resources._5102263421;
            this.btnLogout.Location = new System.Drawing.Point(1518, 19);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(53, 53);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.Location = new System.Drawing.Point(917, 33);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(133, 22);
            this.lblGreetings.TabIndex = 11;
            this.lblGreetings.Text = "GREETINGS  :";
            // 
            // lblnames
            // 
            this.lblnames.AutoSize = true;
            this.lblnames.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnames.Location = new System.Drawing.Point(1100, 33);
            this.lblnames.Name = "lblnames";
            this.lblnames.Size = new System.Drawing.Size(131, 21);
            this.lblnames.TabIndex = 12;
            this.lblnames.Text = "Teacher name";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 913);
            this.Controls.Add(this.lblnames);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.Text = "Mount_Netsai DashBoard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem manageStudentToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editStudentRecordsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem studentPerfomanceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem studentsFeesStatusToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem checkStudentFeesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem humanResourseToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem employeeManagmentToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem registerEmployeeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editEployeeRecordToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem createUsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem enterStudentsExamPerformanceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem veiwStudeentPerfomanceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem leaveApplicationToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolStripMenuItem configurationsToolStripMenuItem;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.ToolStripMenuItem classManagementToolStripMenuItem;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblnames;
    }
}

