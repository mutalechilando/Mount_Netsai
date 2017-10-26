namespace Mount_Netsaiacademy_School_info_sys
{
    partial class Class_Managment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classgrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnssign = new System.Windows.Forms.Button();
            this.cmbyear = new System.Windows.Forms.ComboBox();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbteacher = new System.Windows.Forms.ComboBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.txtclass_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classgrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classgrid);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1298, 656);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // classgrid
            // 
            this.classgrid.BackgroundColor = System.Drawing.Color.White;
            this.classgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classgrid.Location = new System.Drawing.Point(469, 19);
            this.classgrid.Name = "classgrid";
            this.classgrid.Size = new System.Drawing.Size(686, 614);
            this.classgrid.TabIndex = 2;
            this.classgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classgrid_CellContentClick);
            this.classgrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtclass_id);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbyear);
            this.groupBox2.Controls.Add(this.cmbgrade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbteacher);
            this.groupBox2.Controls.Add(this.txtamount);
            this.groupBox2.Controls.Add(this.txtSuffix);
            this.groupBox2.Location = new System.Drawing.Point(18, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 622);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Class";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btnupdate);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.btnssign);
            this.groupBox3.Location = new System.Drawing.Point(13, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 66);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // Btnupdate
            // 
            this.Btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnupdate.Location = new System.Drawing.Point(122, 19);
            this.Btnupdate.Name = "Btnupdate";
            this.Btnupdate.Size = new System.Drawing.Size(113, 23);
            this.Btnupdate.TabIndex = 2;
            this.Btnupdate.Text = "Update";
            this.Btnupdate.UseVisualStyleBackColor = true;
            this.Btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Location = new System.Drawing.Point(241, 20);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 23);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Remove";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnssign
            // 
            this.btnssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnssign.Location = new System.Drawing.Point(6, 19);
            this.btnssign.Name = "btnssign";
            this.btnssign.Size = new System.Drawing.Size(113, 23);
            this.btnssign.TabIndex = 0;
            this.btnssign.Text = "Assign";
            this.btnssign.UseVisualStyleBackColor = true;
            this.btnssign.Click += new System.EventHandler(this.btnssign_Click);
            // 
            // cmbyear
            // 
            this.cmbyear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbyear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.Location = new System.Drawing.Point(93, 121);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(202, 21);
            this.cmbyear.TabIndex = 12;
            this.cmbyear.SelectedIndexChanged += new System.EventHandler(this.cmbyear_SelectedIndexChanged);
            // 
            // cmbgrade
            // 
            this.cmbgrade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Items.AddRange(new object[] {
            "Nursery",
            "Reception",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbgrade.Location = new System.Drawing.Point(93, 69);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(202, 21);
            this.cmbgrade.TabIndex = 11;
            this.cmbgrade.SelectedIndexChanged += new System.EventHandler(this.cmbgrade_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Suffix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Class Year :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Class Teacher :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grade :";
            // 
            // cmbteacher
            // 
            this.cmbteacher.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbteacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbteacher.FormattingEnabled = true;
            this.cmbteacher.Location = new System.Drawing.Point(93, 263);
            this.cmbteacher.Name = "cmbteacher";
            this.cmbteacher.Size = new System.Drawing.Size(268, 21);
            this.cmbteacher.TabIndex = 5;
            this.cmbteacher.SelectedIndexChanged += new System.EventHandler(this.cmbteacher_SelectedIndexChanged);
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(93, 216);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(202, 20);
            this.txtamount.TabIndex = 4;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(93, 168);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(270, 20);
            this.txtSuffix.TabIndex = 2;
            // 
            // txtclass_id
            // 
            this.txtclass_id.Location = new System.Drawing.Point(93, 31);
            this.txtclass_id.Name = "txtclass_id";
            this.txtclass_id.Size = new System.Drawing.Size(202, 20);
            this.txtclass_id.TabIndex = 14;
            this.txtclass_id.Visible = false;
            // 
            // Class_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1336, 681);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Class_Managment";
            this.Text = "Class_Managment";
            this.Load += new System.EventHandler(this.Class_Managment_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classgrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbteacher;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.ComboBox cmbyear;
        private System.Windows.Forms.DataGridView classgrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnssign;
        private System.Windows.Forms.TextBox txtclass_id;
    }
}