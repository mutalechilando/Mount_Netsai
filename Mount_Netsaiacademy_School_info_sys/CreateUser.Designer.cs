namespace Mount_Netsaiacademy_School_info_sys
{
    partial class CreateUser
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.Add_User = new System.Windows.Forms.GroupBox();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pwPass = new System.Windows.Forms.TextBox();
            this.pwConfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpTitle = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.tblEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.Add_User.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataGridViewUsers);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridViewEmployees);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(548, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1047, 820);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "grid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Users";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(580, 77);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(459, 732);
            this.dataGridViewUsers.TabIndex = 2;
            this.dataGridViewUsers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_RowEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Employess";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToOrderColumns = true;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(8, 77);
            this.dataGridViewEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(536, 732);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            this.dataGridViewEmployees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_RowEnter);
            // 
            // Add_User
            // 
            this.Add_User.Controls.Add(this.txtPersonId);
            this.Add_User.Controls.Add(this.txtUserName);
            this.Add_User.Controls.Add(this.pwPass);
            this.Add_User.Controls.Add(this.pwConfirm);
            this.Add_User.Controls.Add(this.label7);
            this.Add_User.Controls.Add(this.label6);
            this.Add_User.Controls.Add(this.groupBox1);
            this.Add_User.Controls.Add(this.label3);
            this.Add_User.Controls.Add(this.label2);
            this.Add_User.Controls.Add(this.label1);
            this.Add_User.Controls.Add(this.txtEmpTitle);
            this.Add_User.Controls.Add(this.txtEmpName);
            this.Add_User.Location = new System.Drawing.Point(16, 15);
            this.Add_User.Margin = new System.Windows.Forms.Padding(4);
            this.Add_User.Name = "Add_User";
            this.Add_User.Padding = new System.Windows.Forms.Padding(4);
            this.Add_User.Size = new System.Drawing.Size(524, 820);
            this.Add_User.TabIndex = 2;
            this.Add_User.TabStop = false;
            this.Add_User.Text = "Add_user";
            // 
            // txtPersonId
            // 
            this.txtPersonId.Enabled = false;
            this.txtPersonId.Location = new System.Drawing.Point(162, 41);
            this.txtPersonId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(345, 22);
            this.txtPersonId.TabIndex = 13;
            this.txtPersonId.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(162, 204);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(345, 22);
            this.txtUserName.TabIndex = 12;
            // 
            // pwPass
            // 
            this.pwPass.Location = new System.Drawing.Point(162, 258);
            this.pwPass.Margin = new System.Windows.Forms.Padding(4);
            this.pwPass.Name = "pwPass";
            this.pwPass.PasswordChar = '*';
            this.pwPass.Size = new System.Drawing.Size(345, 22);
            this.pwPass.TabIndex = 11;
            this.pwPass.UseSystemPasswordChar = true;
            // 
            // pwConfirm
            // 
            this.pwConfirm.Location = new System.Drawing.Point(162, 323);
            this.pwConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.pwConfirm.Name = "pwConfirm";
            this.pwConfirm.PasswordChar = '*';
            this.pwConfirm.Size = new System.Drawing.Size(345, 22);
            this.pwConfirm.TabIndex = 10;
            this.pwConfirm.UseSystemPasswordChar = true;
            this.pwConfirm.TextChanged += new System.EventHandler(this.pwConfirm_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirm Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSaveUser);
            this.groupBox1.Location = new System.Drawing.Point(16, 387);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(500, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(335, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(176, 23);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 28);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveUser.Location = new System.Drawing.Point(32, 23);
            this.btnSaveUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(119, 28);
            this.btnSaveUser.TabIndex = 0;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "UserName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee :";
            // 
            // txtEmpTitle
            // 
            this.txtEmpTitle.Enabled = false;
            this.txtEmpTitle.Location = new System.Drawing.Point(162, 150);
            this.txtEmpTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpTitle.Name = "txtEmpTitle";
            this.txtEmpTitle.Size = new System.Drawing.Size(345, 22);
            this.txtEmpTitle.TabIndex = 1;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(162, 94);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(345, 22);
            this.txtEmpName.TabIndex = 0;
            // 
            // tblEmployeesBindingSource
            // 
            this.tblEmployeesBindingSource.DataMember = "Tbl_Employees";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(136, 204);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(345, 22);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1648, 891);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Add_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.Add_User.ResumeLayout(false);
            this.Add_User.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.GroupBox Add_User;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtEmpTitle;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label4;
        //private Mount_NetsaiAcadamyDataSet5 mount_NetsaiAcadamyDataSet5;
        private System.Windows.Forms.BindingSource tblEmployeesBindingSource;
        //private Mount_NetsaiAcadamyDataSet5TableAdapters.Tbl_EmployeesTableAdapter tbl_EmployeesTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pwPass;
        private System.Windows.Forms.TextBox pwConfirm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPersonId;
    }
}