namespace Mount_Netsaiacademy_School_info_sys
{
    partial class Edit_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Student));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbyear = new System.Windows.Forms.ComboBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.txtStudentNmber = new System.Windows.Forms.TextBox();
            this.cmb_grade = new System.Windows.Forms.ComboBox();
            this.dtpcheck = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mount_NetsaiAcadamyDataSet5 = new Mount_Netsaiacademy_School_info_sys.Mount_NetsaiAcadamyDataSet5();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grideditstud = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbyearr = new System.Windows.Forms.ComboBox();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.txtperson_id = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbstudentstatus = new System.Windows.Forms.ComboBox();
            this.dtpenrollment = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_Student = new System.Windows.Forms.PictureBox();
            this.txtStudent_number = new System.Windows.Forms.TextBox();
            this.txtfee_amount = new System.Windows.Forms.TextBox();
            this.txtteacher = new System.Windows.Forms.TextBox();
            this.tbl_StudentsTableAdapter = new Mount_Netsaiacademy_School_info_sys.Mount_NetsaiAcadamyDataSet5TableAdapters.Tbl_StudentsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mount_NetsaiAcadamyDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grideditstud)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.grideditstud);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1539, 653);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbyear);
            this.groupBox3.Controls.Add(this.cmbstatus);
            this.groupBox3.Controls.Add(this.txtStudentNmber);
            this.groupBox3.Controls.Add(this.cmb_grade);
            this.groupBox3.Controls.Add(this.dtpcheck);
            this.groupBox3.Location = new System.Drawing.Point(382, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1151, 71);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filters";
            // 
            // cmbyear
            // 
            this.cmbyear.BackColor = System.Drawing.Color.White;
            this.cmbyear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.Location = new System.Drawing.Point(956, 30);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(189, 21);
            this.cmbyear.TabIndex = 18;
            this.cmbyear.SelectedIndexChanged += new System.EventHandler(this.cmbyear_SelectedIndexChanged_1);
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Active",
            "Transferred",
            "Expelled",
            "Suspended",
            "Diseased",
            ""});
            this.cmbstatus.Location = new System.Drawing.Point(736, 29);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(203, 21);
            this.cmbstatus.TabIndex = 17;
            this.cmbstatus.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            // 
            // txtStudentNmber
            // 
            this.txtStudentNmber.Location = new System.Drawing.Point(6, 30);
            this.txtStudentNmber.Name = "txtStudentNmber";
            this.txtStudentNmber.Size = new System.Drawing.Size(215, 20);
            this.txtStudentNmber.TabIndex = 16;
            this.txtStudentNmber.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // cmb_grade
            // 
            this.cmb_grade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_grade.FormattingEnabled = true;
            this.cmb_grade.Location = new System.Drawing.Point(507, 30);
            this.cmb_grade.Name = "cmb_grade";
            this.cmb_grade.Size = new System.Drawing.Size(209, 21);
            this.cmb_grade.TabIndex = 3;
            this.cmb_grade.SelectedIndexChanged += new System.EventHandler(this.cmb_grade_SelectedIndexChanged);
            // 
            // dtpcheck
            // 
            this.dtpcheck.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcheck.Location = new System.Drawing.Point(251, 30);
            this.dtpcheck.Name = "dtpcheck";
            this.dtpcheck.Size = new System.Drawing.Size(222, 20);
            this.dtpcheck.TabIndex = 6;
            this.dtpcheck.ValueChanged += new System.EventHandler(this.dtpcheck_ValueChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.tblStudentsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1533, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tblStudentsBindingSource
            // 
            this.tblStudentsBindingSource.DataMember = "Tbl_Students";
            this.tblStudentsBindingSource.DataSource = this.mount_NetsaiAcadamyDataSet5;
            // 
            // mount_NetsaiAcadamyDataSet5
            // 
            this.mount_NetsaiAcadamyDataSet5.DataSetName = "Mount_NetsaiAcadamyDataSet5";
            this.mount_NetsaiAcadamyDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // grideditstud
            // 
            this.grideditstud.BackgroundColor = System.Drawing.Color.White;
            this.grideditstud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grideditstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grideditstud.Location = new System.Drawing.Point(382, 121);
            this.grideditstud.Name = "grideditstud";
            this.grideditstud.Size = new System.Drawing.Size(1151, 525);
            this.grideditstud.TabIndex = 1;
            this.grideditstud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grideditstud_CellContentClick);
            this.grideditstud.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbyearr);
            this.groupBox2.Controls.Add(this.cmbgrade);
            this.groupBox2.Controls.Add(this.txtperson_id);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.cmbstudentstatus);
            this.groupBox2.Controls.Add(this.dtpenrollment);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.picbox_Student);
            this.groupBox2.Controls.Add(this.txtStudent_number);
            this.groupBox2.Controls.Add(this.txtfee_amount);
            this.groupBox2.Controls.Add(this.txtteacher);
            this.groupBox2.Location = new System.Drawing.Point(7, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 602);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // cmbyearr
            // 
            this.cmbyearr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbyearr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbyearr.FormattingEnabled = true;
            this.cmbyearr.Location = new System.Drawing.Point(103, 330);
            this.cmbyearr.Name = "cmbyearr";
            this.cmbyearr.Size = new System.Drawing.Size(202, 21);
            this.cmbyearr.TabIndex = 51;
            this.cmbyearr.SelectedIndexChanged += new System.EventHandler(this.cmbyearr_SelectedIndexChanged);
            // 
            // cmbgrade
            // 
            this.cmbgrade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Location = new System.Drawing.Point(103, 365);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(230, 21);
            this.cmbgrade.TabIndex = 50;
            this.cmbgrade.SelectedIndexChanged += new System.EventHandler(this.cmbgrade_SelectedIndexChanged);
            // 
            // txtperson_id
            // 
            this.txtperson_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "Year", true));
            this.txtperson_id.Location = new System.Drawing.Point(103, 519);
            this.txtperson_id.Name = "txtperson_id";
            this.txtperson_id.Size = new System.Drawing.Size(240, 20);
            this.txtperson_id.TabIndex = 22;
            this.txtperson_id.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(232, 558);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(123, 558);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cmbstudentstatus
            // 
            this.cmbstudentstatus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbstudentstatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "Student_status", true));
            this.cmbstudentstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstudentstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbstudentstatus.FormattingEnabled = true;
            this.cmbstudentstatus.Items.AddRange(new object[] {
            "Active",
            "Transferred",
            "Expelled",
            "Suspended",
            "Diseased",
            ""});
            this.cmbstudentstatus.Location = new System.Drawing.Point(103, 481);
            this.cmbstudentstatus.Name = "cmbstudentstatus";
            this.cmbstudentstatus.Size = new System.Drawing.Size(240, 21);
            this.cmbstudentstatus.TabIndex = 18;
            // 
            // dtpenrollment
            // 
            this.dtpenrollment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "enrollment_date", true));
            this.dtpenrollment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpenrollment.Location = new System.Drawing.Point(103, 247);
            this.dtpenrollment.Name = "dtpenrollment";
            this.dtpenrollment.Size = new System.Drawing.Size(240, 20);
            this.dtpenrollment.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(132, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "upload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Studentstatus :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = " grade :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Year :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Class Teacher :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "date Enrolled :";
            // 
            // picbox_Student
            // 
            this.picbox_Student.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox_Student.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblStudentsBindingSource, "Student_Picture", true));
            this.picbox_Student.Location = new System.Drawing.Point(103, 19);
            this.picbox_Student.Name = "picbox_Student";
            this.picbox_Student.Size = new System.Drawing.Size(179, 180);
            this.picbox_Student.TabIndex = 7;
            this.picbox_Student.TabStop = false;
            // 
            // txtStudent_number
            // 
            this.txtStudent_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "Student_number", true));
            this.txtStudent_number.Location = new System.Drawing.Point(103, 441);
            this.txtStudent_number.Name = "txtStudent_number";
            this.txtStudent_number.Size = new System.Drawing.Size(240, 20);
            this.txtStudent_number.TabIndex = 4;
            // 
            // txtfee_amount
            // 
            this.txtfee_amount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "fee_amount", true));
            this.txtfee_amount.Location = new System.Drawing.Point(103, 405);
            this.txtfee_amount.Name = "txtfee_amount";
            this.txtfee_amount.Size = new System.Drawing.Size(240, 20);
            this.txtfee_amount.TabIndex = 3;
            // 
            // txtteacher
            // 
            this.txtteacher.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "class_Teacher", true));
            this.txtteacher.Location = new System.Drawing.Point(103, 288);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.Size = new System.Drawing.Size(240, 20);
            this.txtteacher.TabIndex = 0;
            this.txtteacher.TextChanged += new System.EventHandler(this.txtteacher_TextChanged);
            // 
            // tbl_StudentsTableAdapter
            // 
            this.tbl_StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // Edit_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1553, 670);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Student";
            this.Text = "Edit_Student";
            this.Load += new System.EventHandler(this.Edit_Student_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mount_NetsaiAcadamyDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grideditstud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_grade;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView grideditstud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_Student;
        private System.Windows.Forms.DateTimePicker dtpcheck;
        private System.Windows.Forms.TextBox txtStudent_number;
        private System.Windows.Forms.TextBox txtfee_amount;
        private System.Windows.Forms.TextBox txtteacher;
        private System.Windows.Forms.TextBox txtStudentNmber;
        private System.Windows.Forms.DateTimePicker dtpenrollment;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.ComboBox cmbstudentstatus;
        private Mount_NetsaiAcadamyDataSet5 mount_NetsaiAcadamyDataSet5;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private Mount_NetsaiAcadamyDataSet5TableAdapters.Tbl_StudentsTableAdapter tbl_StudentsTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbyear;
        private System.Windows.Forms.TextBox txtperson_id;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.ComboBox cmbyearr;
    }
}