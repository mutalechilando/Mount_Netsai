using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Mount_Netsaiacademy_School_info_sys
{

    public partial class register_employee : Form
    {
        public register_employee()
        {
            InitializeComponent();
        }

        private void register_employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet1.Tbl_person_type' table. You can move, or remove it, as needed.
            this.tbl_person_typeTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet1.Tbl_person_type);
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet.Tbl_race' table. You can move, or remove it, as needed.
            this.tbl_raceTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet.Tbl_race);

        }
    }
}
