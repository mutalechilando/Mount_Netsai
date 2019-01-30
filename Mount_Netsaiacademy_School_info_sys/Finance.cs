using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Mount_Netsaiacademy_School_info_sys
{
    public partial class Finance : Form
    {
        DataTable dt = new DataTable();
        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;

        public Finance()
        {
            InitializeComponent();
        }

        private void txtStudent_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void Finance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet5.Tbl_Students' table. You can move, or remove it, as needed.
            //this.tbl_StudentsTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet5.Tbl_Students);
            SqlConnection conn = new SqlConnection(Constr);
            SqlCommand Cmd = new SqlCommand("student_Fees_Management", conn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            dataGridfinance.DataSource = dt;
            this.dataGridfinance.Columns["person_id"].Visible = false;
            this.dataGridfinance.Columns["Class_id"].Visible = false;
            this.dataGridfinance.Columns["Student_Picture"].Visible = false;
            //this.grideditstud.Columns["Class_id"].Visible = false;
            /*
            for (int i = 2007; i <= DateTime.Now.Year; i++)
            {
                cmbyear.Items.Add(i.ToString());// pseudo
            }
            //pull grade

            SqlConnection con = new SqlConnection(Constr);
            String pull_subjects = "pullsubjects";
            SqlCommand cod = new SqlCommand(pull_subjects, con);
            cod.CommandType = CommandType.StoredProcedure;


            try
            {
                con.Open();
                SqlDataReader rd = cod.ExecuteReader();
                while (rd.Read())
                {

                    //cmb_grade.Items.Add(rd["grade"].ToString());
                    //cmbgrade.Items.Add(rd["grade"].ToString());


                }
                rd.Close();

            }

            catch (Exception ex)
            {

                throw new Exception("Execption Transfer of Querry Failed" + ex.Message);


            }

            finally
            {
                con.Close();
            }



            for (int i = 2007; i <= DateTime.Now.Year; i++)
            {
                //cmbyearr.Items.Add(i.ToString());// pseudo
            }
             * 
             */
        }

        private void dataGridfinance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
