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
    public partial class Edit_Student : Form
    {
        DataTable dt = new DataTable();
        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;

        public Edit_Student()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Edit_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet5.Tbl_Students' table. You can move, or remove it, as needed.
            //this.tbl_StudentsTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet5.Tbl_Students);
            SqlConnection conn = new SqlConnection(Constr);
            SqlCommand Cmd = new SqlCommand("student_grid", conn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            grideditstud.DataSource = dt;
            this.grideditstud.Columns["person_id"].Visible = false;
            this.grideditstud.Columns["Class_id"].Visible = false;
            this.grideditstud.Columns["Student_Picture"].Visible = false;
            //this.grideditstud.Columns["Class_id"].Visible = false;

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

                    cmb_grade.Items.Add(rd["grade"].ToString());
                    cmbgrade.Items.Add(rd["grade"].ToString());


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
                cmbyearr.Items.Add(i.ToString());// pseudo
            }

        }

        private void dataGridViewStudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (grideditstud.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                //btnssign.Enabled = false;
                // Btnupdate.Enabled = true;
                // btndelete.Enabled = true;
                var data = (Byte[])(grideditstud.SelectedRows[0].Cells["Student_Picture"].Value);
                var stream = new MemoryStream(data);
                picbox_Student.Image = Image.FromStream(stream);
                //string Student_Picture = grideditstud.SelectedRows[0].Cells[3].Value + string.Empty;
                string Student_number = grideditstud.SelectedRows[0].Cells[4].Value + string.Empty;
                string fee_amount = grideditstud.SelectedRows[0].Cells[5].Value + string.Empty;
                string grade = grideditstud.SelectedRows[0].Cells[6].Value + string.Empty;
                string class_Teacher = grideditstud.SelectedRows[0].Cells[7].Value + string.Empty;
                string Year = grideditstud.SelectedRows[0].Cells[8].Value + string.Empty;
                string enrollment_date = grideditstud.SelectedRows[0].Cells[1].Value + string.Empty;
                string Student_status = grideditstud.SelectedRows[0].Cells[2].Value + string.Empty;
                string person_id = grideditstud.SelectedRows[0].Cells[10].Value + string.Empty;
                //picbox_Student.Image = Student_Picture;
                cmbstudentstatus.Text = Student_number;
                txtfee_amount.Text = fee_amount;
                cmbgrade.Text = grade;
                txtteacher.Text = class_Teacher;
                cmbyearr.Text = Year;
                dtpenrollment.Text = enrollment_date;
                txtStudent_number.Text = Student_number;
                cmbstudentstatus.Text = Student_status;
                txtperson_id.Text = person_id;
            }

        }

        private void cmbyear_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Constr);
            String pull_Year = "GetAllFROMYEAR";
            SqlCommand cmd = new SqlCommand(pull_Year, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Year", cmbyear.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();



                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                grideditstud.DataSource = dt;




                con.Close();
            }

            catch (Exception ex)
            {

                throw new Exception("Execption Transfer of Querry Failed" + ex.Message);


            }

            finally
            {
                con.Close();
            }
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlConnection con = new SqlConnection(Constr);
                String pull_Year = "GetAllFROMSTATUS";
                SqlCommand cmd = new SqlCommand(pull_Year, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Status", cmbstatus.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();



                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    grideditstud.DataSource = dt;




                    con.Close();
                }

                catch (Exception ex)
                {

                    throw new Exception("Execption Transfer of Querry Failed" + ex.Message);


                }

                finally
                {
                    con.Close();
                }
            }
        }

        private void dtpcheck_ValueChanged(object sender, EventArgs e)
        {
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlConnection con = new SqlConnection(Constr);
                String pull_Year = "GetAllFROMDATE";
                SqlCommand cmd = new SqlCommand(pull_Year, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Date",dtpcheck.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();



                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    grideditstud.DataSource = dt;




                    con.Close();
                }

                catch (Exception ex)
                {

                    throw new Exception("Execption Transfer of Querry Failed" + ex.Message);


                }

                finally
                {
                    con.Close();
                }
            }

        }

        private void cmb_grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlConnection con = new SqlConnection(Constr);
                String pull_Year = "GetAllFROMGRADE";
                SqlCommand cmd = new SqlCommand(pull_Year, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GRADE",cmb_grade.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();



                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    grideditstud.DataSource = dt;




                    con.Close();
                }

                catch (Exception ex)
                {

                    throw new Exception("Execption Transfer of Querry Failed" + ex.Message);


                }

                finally
                {
                    con.Close();
                }
            }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(Constr);
            String pull_Year = "GetAllFROMStudentNO";
            SqlCommand cmd = new SqlCommand(pull_Year, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentNo",txtStudentNmber.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();



                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                grideditstud.DataSource = dt;




                con.Close();
            }

            catch (Exception ex)
            {

                throw new Exception("Execption Transfer of Querry Failed" + ex.Message);


            }

            finally
            {
                con.Close();
            }
        }

        private void grideditstud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            String pull_classdetails = "pullclassdetials";
            SqlCommand cmd = new SqlCommand(pull_classdetails, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@grade", cmbgrade.Text);

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    txtfee_amount.Text = rd["fee_amount"].ToString();
                    //txtclassid.Text = rd["class_id"].ToString();
                    cmbyearr.Text = rd["class_Year"].ToString();
                    txtteacher.Text = rd["class_teacher"].ToString();



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
           
        }

        private void cmbyearr_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void txtteacher_TextChanged(object sender, EventArgs e)
        {

        }
           
        }
        }
