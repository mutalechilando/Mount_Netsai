namespace Mount_Netsaiacademy_School_info_sys
{
    partial class register_employee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbdisability = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.tblraceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mount_NetsaiAcadamyDataSet = new Mount_Netsaiacademy_School_info_sys.Mount_NetsaiAcadamyDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbemptype = new System.Windows.Forms.ComboBox();
            this.tblpersontypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mount_NetsaiAcadamyDataSet1 = new Mount_Netsaiacademy_School_info_sys.Mount_NetsaiAcadamyDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.tbl_raceTableAdapter = new Mount_Netsaiacademy_School_info_sys.Mount_NetsaiAcadamyDataSetTableAdapters.Tbl_raceTableAdapter();
            this.tbl_person_typeTableAdapter = new Mount_Netsaiacademy_School_info_sys.Mount_NetsaiAcadamyDataSet1TableAdapters.Tbl_person_typeTableAdapter();
            this.Txt_NRC = new System.Windows.Forms.MaskedTextBox();
            this.dtp_employment_date = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdayspermonth = new System.Windows.Forms.TextBox();
            this.Marital_Status = new System.Windows.Forms.ComboBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtemptype = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblraceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mount_NetsaiAcadamyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersontypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mount_NetsaiAcadamyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtemptype);
            this.groupBox1.Controls.Add(this.Txt_NRC);
            this.groupBox1.Controls.Add(this.dtp_employment_date);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtdayspermonth);
            this.groupBox1.Controls.Add(this.Marital_Status);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbdisability);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbRace);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbgender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_dateofbirth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbemptype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register_Employee";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(462, 238);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(46, 20);
            this.txtAge.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Age :";
            // 
            // cmbdisability
            // 
            this.cmbdisability.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbdisability.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbdisability.FormattingEnabled = true;
            this.cmbdisability.Items.AddRange(new object[] {
            "none",
            "Deaf",
            "Dumb",
            "Blind",
            "Lame"});
            this.cmbdisability.Location = new System.Drawing.Point(100, 230);
            this.cmbdisability.Name = "cmbdisability";
            this.cmbdisability.Size = new System.Drawing.Size(230, 21);
            this.cmbdisability.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Disability :";
            // 
            // cmbRace
            // 
            this.cmbRace.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbRace.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblraceBindingSource, "race_type", true));
            this.cmbRace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Location = new System.Drawing.Point(462, 180);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(230, 21);
            this.cmbRace.TabIndex = 11;
            this.cmbRace.SelectedIndexChanged += new System.EventHandler(this.cmbRace_SelectedIndexChanged);
            // 
            // tblraceBindingSource
            // 
            this.tblraceBindingSource.DataMember = "Tbl_race";
            this.tblraceBindingSource.DataSource = this.mount_NetsaiAcadamyDataSet;
            // 
            // mount_NetsaiAcadamyDataSet
            // 
            this.mount_NetsaiAcadamyDataSet.DataSetName = "Mount_NetsaiAcadamyDataSet";
            this.mount_NetsaiAcadamyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Race :";
            // 
            // cmbgender
            // 
            this.cmbgender.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbgender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(100, 175);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(230, 21);
            this.cmbgender.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth :";
            // 
            // dtp_dateofbirth
            // 
            this.dtp_dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateofbirth.Location = new System.Drawing.Point(462, 120);
            this.dtp_dateofbirth.Name = "dtp_dateofbirth";
            this.dtp_dateofbirth.Size = new System.Drawing.Size(230, 20);
            this.dtp_dateofbirth.TabIndex = 6;
            this.dtp_dateofbirth.ValueChanged += new System.EventHandler(this.dtp_dateofbirth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Type :";
            // 
            // cmbemptype
            // 
            this.cmbemptype.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbemptype.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblpersontypeBindingSource, "person_type", true));
            this.cmbemptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbemptype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbemptype.FormattingEnabled = true;
            this.cmbemptype.Location = new System.Drawing.Point(100, 119);
            this.cmbemptype.Name = "cmbemptype";
            this.cmbemptype.Size = new System.Drawing.Size(230, 21);
            this.cmbemptype.TabIndex = 4;
            this.cmbemptype.SelectedIndexChanged += new System.EventHandler(this.cmbemptype_SelectedIndexChanged);
            // 
            // tblpersontypeBindingSource
            // 
            this.tblpersontypeBindingSource.DataMember = "Tbl_person_type";
            this.tblpersontypeBindingSource.DataSource = this.mount_NetsaiAcadamyDataSet1;
            // 
            // mount_NetsaiAcadamyDataSet1
            // 
            this.mount_NetsaiAcadamyDataSet1.DataSetName = "Mount_NetsaiAcadamyDataSet1";
            this.mount_NetsaiAcadamyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name :";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(462, 64);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(230, 20);
            this.txtLname.TabIndex = 2;
            this.txtLname.TextChanged += new System.EventHandler(this.txtLname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name :";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(100, 64);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(230, 20);
            this.txtFname.TabIndex = 0;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // tbl_raceTableAdapter
            // 
            this.tbl_raceTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_person_typeTableAdapter
            // 
            this.tbl_person_typeTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_NRC
            // 
            this.Txt_NRC.Location = new System.Drawing.Point(100, 280);
            this.Txt_NRC.Mask = "000000\\/00\\/0";
            this.Txt_NRC.Name = "Txt_NRC";
            this.Txt_NRC.Size = new System.Drawing.Size(217, 20);
            this.Txt_NRC.TabIndex = 37;
            // 
            // dtp_employment_date
            // 
            this.dtp_employment_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_employment_date.Location = new System.Drawing.Point(462, 326);
            this.dtp_employment_date.Name = "dtp_employment_date";
            this.dtp_employment_date.Size = new System.Drawing.Size(230, 20);
            this.dtp_employment_date.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Employment Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Marital Status :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "days per month :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nrc :";
            // 
            // txtdayspermonth
            // 
            this.txtdayspermonth.Enabled = false;
            this.txtdayspermonth.Location = new System.Drawing.Point(100, 324);
            this.txtdayspermonth.Name = "txtdayspermonth";
            this.txtdayspermonth.Size = new System.Drawing.Size(44, 20);
            this.txtdayspermonth.TabIndex = 31;
            // 
            // Marital_Status
            // 
            this.Marital_Status.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Marital_Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Marital_Status.FormattingEnabled = true;
            this.Marital_Status.Items.AddRange(new object[] {
            "Single",
            "Marriade",
            "Divosed",
            "Widowed",
            "Separeted"});
            this.Marital_Status.Location = new System.Drawing.Point(462, 278);
            this.Marital_Status.Name = "Marital_Status";
            this.Marital_Status.Size = new System.Drawing.Size(230, 21);
            this.Marital_Status.TabIndex = 30;
            // 
            // btncancel
            // 
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Location = new System.Drawing.Point(496, 400);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(160, 35);
            this.btncancel.TabIndex = 29;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Location = new System.Drawing.Point(100, 400);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 35);
            this.btnRegister.TabIndex = 28;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtemptype
            // 
            this.txtemptype.Location = new System.Drawing.Point(656, 19);
            this.txtemptype.Name = "txtemptype";
            this.txtemptype.Size = new System.Drawing.Size(36, 20);
            this.txtemptype.TabIndex = 38;
            this.txtemptype.Text = "1";
            this.txtemptype.Visible = false;
            this.txtemptype.TextChanged += new System.EventHandler(this.txtemptype_TextChanged);
            // 
            // register_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 518);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "register_employee";
            this.Text = "register_employee";
            this.Load += new System.EventHandler(this.register_employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblraceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mount_NetsaiAcadamyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersontypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mount_NetsaiAcadamyDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dateofbirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbdisability;
        private System.Windows.Forms.Label label7;
        private Mount_NetsaiAcadamyDataSet mount_NetsaiAcadamyDataSet;
        private System.Windows.Forms.BindingSource tblraceBindingSource;
        private Mount_NetsaiAcadamyDataSetTableAdapters.Tbl_raceTableAdapter tbl_raceTableAdapter;
        private Mount_NetsaiAcadamyDataSet1 mount_NetsaiAcadamyDataSet1;
        private System.Windows.Forms.BindingSource tblpersontypeBindingSource;
        private Mount_NetsaiAcadamyDataSet1TableAdapters.Tbl_person_typeTableAdapter tbl_person_typeTableAdapter;
        private System.Windows.Forms.ComboBox cmbemptype;
        private System.Windows.Forms.TextBox txtemptype;
        private System.Windows.Forms.MaskedTextBox Txt_NRC;
        private System.Windows.Forms.DateTimePicker dtp_employment_date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdayspermonth;
        private System.Windows.Forms.ComboBox Marital_Status;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnRegister;
    }
}