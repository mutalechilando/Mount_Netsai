using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;


namespace Mount_Netsaiacademy_School_info_sys
{
    public partial class StudentRegistration : Form
    {
        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;
        public StudentRegistration()
        {
            InitializeComponent();
        }

        public static string randomString(int length)
        {

            const string chars = "ABCDEUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            ///race pull
            SqlConnection con = new SqlConnection(Constr);
            txtStudentNumber.Text = randomString(10);

            String pull_race = "Racepull";
            SqlCommand cmd = new SqlCommand(pull_race, con);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    cmbrace.Items.Add(rd["race_type"].ToString());


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

            //////////////////////////////////////////////////pull grade
            String pull_subjects = "pullsubjects";
            SqlCommand cod = new SqlCommand(pull_subjects, con);
            cod.CommandType = CommandType.StoredProcedure;


            try
            {
                con.Open();
                SqlDataReader rd = cod.ExecuteReader();
                while (rd.Read())
                {

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



        
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }      
      
        private void button1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void txtfname_TextChanged_1(object sender, EventArgs e)
        {
            if (txtfname.Text.ToCharArray().Any(char.IsDigit))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                // txtLname.Text.Remove(txtLname.Text.Length - 1);
                txtfname.Text = "";

            }
        }

        private void txtlastname_TextChanged_1(object sender, EventArgs e)
        {
            if (txtlastname.Text.ToCharArray().Any(char.IsDigit))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                // txtLname.Text.Remove(txtLname.Text.Length - 1);
                txtlastname.Text = "";

            }
        }

        private void dtp_date_of_birth_ValueChanged(object sender, EventArgs e)
        {
            int CurrentAge = DateTime.Today.Year - dtp_date_of_birth.Value.Year;
            txtage.Text = CurrentAge.ToString();
        }

        private void btnregister_Click_1(object sender, EventArgs e)
        {
            if (txtfname.Text == "")
            {
                MessageBox.Show("firstname Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtlastname.Text == "")
            {
                MessageBox.Show("lastname Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtStudentNumber.Text == "")
            {
                MessageBox.Show("Student Number Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbgender.Text == "")
            {
                MessageBox.Show("Gender Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (cmbdisability.Text == "")
            {
                MessageBox.Show("disability Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbrace.Text == "")
            {
                MessageBox.Show("Race Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtage.Text == "")
            {
                MessageBox.Show("Age Field cannot be empty please ensure the date of birth is valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dTp_enroll.Text == "")
            {
                MessageBox.Show("Enrollment date Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtstudentstatus.Text == "      /  /")
            {
                MessageBox.Show("Student status cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (Int16.Parse(txtage.Text) < 2)
            {
                MessageBox.Show("This Student is Under Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                SqlConnection con = new SqlConnection(Constr);
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();

                String Add_people = "Insert_People";
                SqlCommand cmd = new SqlCommand(Add_people, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Firstname", txtfname.Text.Trim());
                cmd.Parameters.AddWithValue("@Lastname", txtlastname.Text.Trim());
                cmd.Parameters.AddWithValue("@PersonType", txtemptype.Text.Trim());
                cmd.Parameters.AddWithValue("@Age", txtage.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", cmbgender.SelectedIndex.ToString().Trim());
                cmd.Parameters.AddWithValue("@Race", cmbrace.SelectedIndex.ToString().Trim());
                cmd.Parameters.AddWithValue("@Disability", cmbdisability.Text.Trim());
                cmd.Parameters.AddWithValue("@date_of_birth", dtp_date_of_birth.Text.Trim());
                cmd.Parameters.AddWithValue("@marital_status", DBNull.Value);
                cmd.Parameters.AddWithValue("@NRC", DBNull.Value);
                cmd.Parameters.AddWithValue("@leave_days_per_month", DBNull.Value);
                cmd.Parameters.AddWithValue("@Employment_date", DBNull.Value);
                cmd.Parameters.AddWithValue("@employeetitle", DBNull.Value);
                cmd.Parameters.AddWithValue("@Student_enrollmentdate", dTp_enroll.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@student_status", "Active");
                cmd.Parameters.AddWithValue("@student_picture", pic);
                cmd.Parameters.AddWithValue("@student_number", txtStudentNumber.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@Student_Grade", cmbgrade.Text.Trim());
                cmd.Parameters.AddWithValue("@class_amount", txtamount.Text.Trim());
                cmd.Parameters.AddWithValue("@class_teacher", txtclassteacher.Text.Trim());
                cmd.Parameters.AddWithValue("@class_year", txtyear.Text.Trim());
                cmd.Parameters.AddWithValue("@Class_id", txtclassid.Text.Trim());
                cmd.Parameters.AddWithValue("@amountpaid", txtamountpayed.Text.Trim());

                try
                {
                    con.Open();


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtfname.Text = "";
                    txtlastname.Text = "";
                    txtage.Text = "";
                    cmbgender.Text = "";
                    cmbrace.Text = "";
                    cmbdisability.Text = "";
                    cmbdisability.Text = "";
                    dtp_date_of_birth.Text = "";
                    dTp_enroll.Text = "";
                    //pictureBox1.Image.Dispose();
                    txtStudentNumber.Text = "";
                    txtamount.Text = "";
                    txtclassid.Text = "";
                    txtclassteacher.Text = "";
                    txtyear.Text = "";
                    txtStudentNumber.Text = randomString(10);

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

        private void cmbrace_SelectedIndexChanged(object sender, EventArgs e)
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

                    txtamount.Text=rd["fee_amount"].ToString();
                    txtclassid.Text = rd["class_id"].ToString();
                    txtyear.Text = rd["class_Year"].ToString();
                    txtclassteacher.Text = rd["class_teacher"].ToString();
                  


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

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

