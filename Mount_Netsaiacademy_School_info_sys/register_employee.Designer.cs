﻿namespace Mount_Netsaiacademy_School_info_sys
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblraceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mount_NetsaiAcadamyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersontypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mount_NetsaiAcadamyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1021, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register_Employee";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(709, 394);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(213, 43);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(133, 394);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(213, 43);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(616, 293);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(305, 22);
            this.txtAge.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
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
            this.cmbdisability.Location = new System.Drawing.Point(133, 283);
            this.cmbdisability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbdisability.Name = "cmbdisability";
            this.cmbdisability.Size = new System.Drawing.Size(305, 24);
            this.cmbdisability.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Disability :";
            // 
            // cmbRace
            // 
            this.cmbRace.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbRace.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblraceBindingSource, "race_type", true));
            this.cmbRace.DataSource = this.tblraceBindingSource;
            this.cmbRace.DisplayMember = "race_type";
            this.cmbRace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Location = new System.Drawing.Point(616, 222);
            this.cmbRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(305, 24);
            this.cmbRace.TabIndex = 11;
            this.cmbRace.ValueMember = "race_type";
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
            this.label6.Location = new System.Drawing.Point(545, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
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
            this.cmbgender.Location = new System.Drawing.Point(133, 215);
            this.cmbgender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(305, 24);
            this.cmbgender.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth :";
            // 
            // dtp_dateofbirth
            // 
            this.dtp_dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateofbirth.Location = new System.Drawing.Point(616, 148);
            this.dtp_dateofbirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_dateofbirth.Name = "dtp_dateofbirth";
            this.dtp_dateofbirth.Size = new System.Drawing.Size(305, 22);
            this.dtp_dateofbirth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Type :";
            // 
            // cmbemptype
            // 
            this.cmbemptype.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbemptype.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblpersontypeBindingSource, "person_type", true));
            this.cmbemptype.DataSource = this.tblpersontypeBindingSource;
            this.cmbemptype.DisplayMember = "person_type";
            this.cmbemptype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbemptype.FormattingEnabled = true;
            this.cmbemptype.Location = new System.Drawing.Point(133, 146);
            this.cmbemptype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbemptype.Name = "cmbemptype";
            this.cmbemptype.Size = new System.Drawing.Size(305, 24);
            this.cmbemptype.TabIndex = 4;
            this.cmbemptype.ValueMember = "person_type";
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
            this.label2.Location = new System.Drawing.Point(512, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name :";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(616, 79);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(305, 22);
            this.txtLname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name :";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(133, 79);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(305, 22);
            this.txtFname.TabIndex = 0;
            // 
            // tbl_raceTableAdapter
            // 
            this.tbl_raceTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_person_typeTableAdapter
            // 
            this.tbl_person_typeTableAdapter.ClearBeforeFill = true;
            // 
            // register_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 638);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox cmbemptype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbdisability;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnRegister;
        private Mount_NetsaiAcadamyDataSet mount_NetsaiAcadamyDataSet;
        private System.Windows.Forms.BindingSource tblraceBindingSource;
        private Mount_NetsaiAcadamyDataSetTableAdapters.Tbl_raceTableAdapter tbl_raceTableAdapter;
        private Mount_NetsaiAcadamyDataSet1 mount_NetsaiAcadamyDataSet1;
        private System.Windows.Forms.BindingSource tblpersontypeBindingSource;
        private Mount_NetsaiAcadamyDataSet1TableAdapters.Tbl_person_typeTableAdapter tbl_person_typeTableAdapter;
    }
}