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
using System.Globalization;
using System.Windows.Forms.VisualStyles;

namespace Mount_Netsaiacademy_School_info_sys
{
    public partial class StudentPrerfomance : Form
    {

        DataTable dt = new DataTable();
        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;
       
        
        public StudentPrerfomance()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StudentPrerfomance_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfullnames.Text))
            {
                btnpostresorts.Enabled = false;
                btnupdateresults.Enabled = true;
                btndeleteresults.Enabled = true;


            }
            
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet5.Tbl_Students' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet5.Tbl_Students' table. You can move, or remove it, as needed.
            //this.tbl_StudentsTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet5.Tbl_Students);
            //lblTeachername.Text = 
            lbltime.Text = DateTime.Now.ToString();
            lblTeachername.Text = Login.type;
            lblposition.Text = Login.position;
           
          
            SqlConnection conn = new SqlConnection(Constr);
            SqlCommand Cmd = new SqlCommand("student_grid_performance", conn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@class_Tech",Login.type);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            gridperfomance.DataSource = dt;
            this.gridperfomance.Columns["person_id"].Visible = true;
            this.gridperfomance.Columns["Class_id"].Visible = true;
            this.gridperfomance.Columns["Student_Picture"].Visible = false;
            this.gridperfomance.Columns["fee_amount"].Visible = false;

            try {
              

            
            
            
            
            }
            catch (Exception ex)
            {


                throw new Exception("failed to pull students for class teacher" + ex.Message);

            }

           

        }

        private void gridperfomance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
   

           if (gridperfomance.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                btnpostresorts.Enabled = true;
                btnupdateresults.Enabled = true;
                btndeleteresults.Enabled = true;


                
                var data = (Byte[])(gridperfomance.SelectedRows[0].Cells["Student_Picture"].Value);
                var stream = new MemoryStream(data);
                photo.Image = Image.FromStream(stream);
                string Full_Names = gridperfomance.SelectedRows[0].Cells[0].Value + string.Empty;
                string Student_number = gridperfomance.SelectedRows[0].Cells[4].Value + string.Empty;
                string grade = gridperfomance.SelectedRows[0].Cells[6].Value + string.Empty;
                string class_Teacher = gridperfomance.SelectedRows[0].Cells[7].Value + string.Empty;
                string Sub1 = gridperfomance.SelectedRows[0].Cells[9].Value + string.Empty;
                string Sub2 = gridperfomance.SelectedRows[0].Cells[10].Value + string.Empty;
                string Sub3 = gridperfomance.SelectedRows[0].Cells[11].Value + string.Empty;
                string Sub4 = gridperfomance.SelectedRows[0].Cells[12].Value + string.Empty;
                string Sub5 = gridperfomance.SelectedRows[0].Cells[13].Value + string.Empty;
                string Sub6 = gridperfomance.SelectedRows[0].Cells[14].Value + string.Empty;
                string Sub7 = gridperfomance.SelectedRows[0].Cells[15].Value + string.Empty;
                string Sub8 = gridperfomance.SelectedRows[0].Cells[16].Value + string.Empty;
                string Year = gridperfomance.SelectedRows[0].Cells[8].Value + string.Empty;
                //string Student_status = gridperfomance.SelectedRows[0].Cells[2].Value + string.Empty;
                string person_id = gridperfomance.SelectedRows[0].Cells["person_id"].Value + string.Empty;
                string class_id = gridperfomance.SelectedRows[0].Cells["Class_id"].Value + string.Empty;

                txtfullnames.Text = Full_Names;
                txtstudNo.Text = Student_number;
                txtstudgrade.Text = grade;
                txtclass_teacher.Text = class_Teacher;
                textsub1.Text = Sub1;
                textsub2.Text = Sub2;
                textsub3.Text = Sub3;
                textsub4.Text = Sub4;
                textsub5.Text = Sub5;
                textsub6.Text = Sub6;
                textsub7.Text = Sub7;
                textsub8.Text = Sub8;
                txtyear.Text = Year;
                txtClassGuid.Text = class_id;
                txtStudentGuid.Text = person_id;



            }

           

            /*////////////////////////test
           if (textsub8.Text == "" && textsub7.Text == "" && textsub6.Text == "" && textsub5.Text == "" && textsub4.Text == "" && textsub3.Text == "" && textsub2.Text == "" && textsub1.Text == "")
           {
               textBox20.Enabled = false;
               textBox19.Enabled = false;
               textBox18.Enabled = false;
               textBox16.Enabled = false;
               textBox17.Enabled = false;
               textBox15.Enabled = false;
               textBox14.Enabled = false;
               textBox13.Enabled = false;


           }






           else if (textsub8.Text == "" && textsub7.Text == "" && textsub6.Text == "" && textsub5.Text == "" && textsub4.Text == "" && textsub3.Text == "" && textsub2.Text == "")
           {
               textBox20.Enabled = false;
               textBox19.Enabled = false;
               textBox18.Enabled = false;
               textBox16.Enabled = false;
               textBox17.Enabled = false;
               textBox15.Enabled = false;
               textBox14.Enabled = false;
               textBox13.Enabled = true;

           }

           else if (textsub8.Text == "" && textsub7.Text == "" && textsub6.Text == "" && textsub5.Text == "" && textsub4.Text == "" && textsub3.Text == "")
           {
               textBox20.Enabled = false;
               textBox19.Enabled = false;
               textBox18.Enabled = false;
               textBox16.Enabled = false;
               textBox17.Enabled = false;
               textBox15.Enabled = false;
               textBox14.Enabled = true;
               textBox13.Enabled = true;

           }

           else if (textsub8.Text == "" && textsub7.Text == "" && textsub6.Text == "" && textsub5.Text == "" && textsub4.Text == "")
           {
               textBox20.Enabled = false;
               textBox19.Enabled = false;
               textBox18.Enabled = false;
               textBox16.Enabled = false;
               textBox17.Enabled = false;
               textBox15.Enabled = true;
               textBox14.Enabled = true;
               textBox13.Enabled = true;

           }
           else if (textsub8.Text == "" && textsub7.Text == "" && textsub6.Text == "" && textsub5.Text == "")
           {
               textBox20.Enabled = false;
               textBox19.Enabled = false;
               textBox18.Enabled = false;
               textBox16.Enabled = false;
               textBox17.Enabled = true;
               textBox15.Enabled = true;
               textBox14.Enabled = true;
               textBox13.Enabled = true;

           }

           else if (textsub8.Text == "" && textsub7.Text == "" && textsub6.Text == "")
           {
               textBox20.Enabled = false;
               textBox19.Enabled = false;
               textBox18.Enabled = false;
               textBox16.Enabled = true;
               textBox17.Enabled = true;
               textBox15.Enabled = true;
               textBox14.Enabled = true;
               textBox13.Enabled = true;

           }

           else if (textsub8.Text == "" && textsub7.Text == "")
           {
               textBox20.Enabled = false;
               textBox19.Enabled = false;
               textBox18.Enabled = true;
               textBox16.Enabled = true;
               textBox17.Enabled = true;
               textBox15.Enabled = true;
               textBox14.Enabled = true;
               textBox13.Enabled = true;

           }
           else if (textsub8.Text == "")
           {
               textBox20.Enabled = false;
               textBox19.Enabled = true;
               textBox18.Enabled = true;
               textBox16.Enabled = true;
               textBox17.Enabled = true;
               textBox15.Enabled = true;
               textBox14.Enabled = true;
               textBox13.Enabled = true;

           }
           else
           {
               textBox20.Enabled = true;
               textBox19.Enabled = true;
               textBox18.Enabled = true;
               textBox16.Enabled = true;
               textBox17.Enabled = true;
               textBox15.Enabled = true;
               textBox14.Enabled = true;
               textBox13.Enabled = true;


           }
/////////////////////////////////////end*/

     

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpostresorts_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);

            if (!string.IsNullOrEmpty(textsub1.Text) && !string.IsNullOrEmpty(textBox13.Text))
            {
                String Add_Test_Results = "Add_Test_Results";
                SqlCommand cmd = new SqlCommand(Add_Test_Results, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@personId",Guid.Parse(txtStudentGuid.Text));
                cmd.Parameters.AddWithValue("@classId", Guid.Parse(txtClassGuid.Text));
                cmd.Parameters.AddWithValue("@term",comboterm.Text);
                cmd.Parameters.AddWithValue("@classSubject",textsub1.Text.Trim());
                cmd.Parameters.AddWithValue("@results", textBox13.Text);
                cmd.Parameters.AddWithValue("@studentNo", txtstudNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (!string.IsNullOrEmpty(textsub2.Text) && !string.IsNullOrEmpty(textBox14.Text))
            {
                String Add_Test_Results = "Add_Test_Results";
                SqlCommand cmd = new SqlCommand(Add_Test_Results, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@personId", Guid.Parse(txtStudentGuid.Text));
                cmd.Parameters.AddWithValue("@classId", Guid.Parse(txtClassGuid.Text));
                cmd.Parameters.AddWithValue("@term", comboterm.Text);
                cmd.Parameters.AddWithValue("@classSubject", textsub2.Text.Trim());
                cmd.Parameters.AddWithValue("@results", textBox14.Text);
                cmd.Parameters.AddWithValue("@studentNo", txtstudNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (!string.IsNullOrEmpty(textsub3.Text) && !string.IsNullOrEmpty(textBox15.Text))
            {
                String Add_Test_Results = "Add_Test_Results";
                SqlCommand cmd = new SqlCommand(Add_Test_Results, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@personId", Guid.Parse(txtStudentGuid.Text));
                cmd.Parameters.AddWithValue("@classId", Guid.Parse(txtClassGuid.Text));
                cmd.Parameters.AddWithValue("@term", comboterm.Text);
                cmd.Parameters.AddWithValue("@classSubject", textsub3.Text.Trim());
                cmd.Parameters.AddWithValue("@results", textBox15.Text);
                cmd.Parameters.AddWithValue("@studentNo", txtstudNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (!string.IsNullOrEmpty(textsub4.Text) && !string.IsNullOrEmpty(textBox16.Text))
            {
                String Add_Test_Results = "Add_Test_Results";
                SqlCommand cmd = new SqlCommand(Add_Test_Results, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@personId", Guid.Parse(txtStudentGuid.Text));
                cmd.Parameters.AddWithValue("@classId", Guid.Parse(txtClassGuid.Text));
                cmd.Parameters.AddWithValue("@term", comboterm.Text);
                cmd.Parameters.AddWithValue("@classSubject", textsub4.Text.Trim());
                cmd.Parameters.AddWithValue("@results", textBox16.Text);
                cmd.Parameters.AddWithValue("@studentNo", txtstudNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (!string.IsNullOrEmpty(textsub5.Text) && !string.IsNullOrEmpty(textBox17.Text))
            {
                String Add_Test_Results = "Add_Test_Results";
                SqlCommand cmd = new SqlCommand(Add_Test_Results, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@personId", Guid.Parse(txtStudentGuid.Text));
                cmd.Parameters.AddWithValue("@classId", Guid.Parse(txtClassGuid.Text));
                cmd.Parameters.AddWithValue("@term", comboterm.Text);
                cmd.Parameters.AddWithValue("@classSubject", textsub5.Text.Trim());
                cmd.Parameters.AddWithValue("@results", textBox17.Text);
                cmd.Parameters.AddWithValue("@studentNo", txtstudNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (!string.IsNullOrEmpty(textsub6.Text) && !string.IsNullOrEmpty(textBox18.Text))
            {
                String Add_Test_Results = "Add_Test_Results";
                SqlCommand cmd = new SqlCommand(Add_Test_Results, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@personId", Guid.Parse(txtStudentGuid.Text));
                cmd.Parameters.AddWithValue("@classId", Guid.Parse(txtClassGuid.Text));
                cmd.Parameters.AddWithValue("@term", comboterm.Text);
                cmd.Parameters.AddWithValue("@classSubject", textsub6.Text.Trim());
                cmd.Parameters.AddWithValue("@results", textBox18.Text);
                cmd.Parameters.AddWithValue("@studentNo", txtstudNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (!string.IsNullOrEmpty(textsub7.Text) && !string.IsNullOrEmpty(textBox19.Text))
            {
                String Add_Test_Results = "Add_Test_Results";
                SqlCommand cmd = new SqlCommand(Add_Test_Results, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@personId", Guid.Parse(txtStudentGuid.Text));
                cmd.Parameters.AddWithValue("@classId", Guid.Parse(txtClassGuid.Text));
                cmd.Parameters.AddWithValue("@term", comboterm.Text);
                cmd.Parameters.AddWithValue("@classSubject", textsub7.Text.Trim());
                cmd.Parameters.AddWithValue("@results", textBox19.Text);
                cmd.Parameters.AddWithValue("@studentNo", txtstudNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (!string.IsNullOrEmpty(textsub8.Text) && !string.IsNullOrEmpty(textBox20.Text))
            {
                String Add_Test_Results = "Add_Test_Results";
                SqlCommand cmd = new SqlCommand(Add_Test_Results, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@personId", Guid.Parse(txtStudentGuid.Text));
                cmd.Parameters.AddWithValue("@classId", Guid.Parse(txtClassGuid.Text));
                cmd.Parameters.AddWithValue("@term", comboterm.Text);
                cmd.Parameters.AddWithValue("@classSubject", textsub8.Text.Trim());
                cmd.Parameters.AddWithValue("@results", textBox20.Text);
                cmd.Parameters.AddWithValue("@studentNo", txtstudNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
