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
        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;

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

            // combo box reader /// for Race Type
            SqlConnection con = new SqlConnection(Constr);
            String pull_race = "Racepull";
            SqlCommand cmd = new SqlCommand(pull_race,con);
            cmd.CommandType = CommandType.StoredProcedure;

             
           try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
               while (rd.Read())
                 {

                   cmbRace.Items.Add(rd["race_type"].ToString());
                            
                             
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

            ////employee pull
           String Emp_race = "PullEmpType";
           SqlCommand cmdd = new SqlCommand(Emp_race, con);
           cmdd.CommandType = CommandType.StoredProcedure;

           try
           {
               con.Open();
               SqlDataReader rd = cmdd.ExecuteReader();
               while (rd.Read())
               {

                   cmbemptype.Items.Add(rd["person_type"].ToString());


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
       

        private void cmbemptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbemptype.Text == "Manager")
            {

                txtdayspermonth.Text = "2";


            }
            else if (cmbemptype.Text == "Teacher")
            {
                txtdayspermonth.Text = "2";
            }

            else if (cmbemptype.Text == "Principal")
            {
                txtdayspermonth.Text = "2";
            }
            else if (cmbemptype.Text == "Administrator")
            {
                txtdayspermonth.Text = "2";
            }

        }

        private void cmbRace_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtemptype_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            if (txtFname.Text.ToCharArray().Any(char.IsDigit))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                // txtLname.Text.Remove(txtLname.Text.Length - 1);
                txtFname.Text = "";

            }
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            if (txtLname.Text.ToCharArray().Any(char.IsDigit))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                // txtLname.Text.Remove(txtLname.Text.Length - 1);
                txtLname.Text = "";

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "")
            {
                MessageBox.Show("firstname Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtLname.Text == "")
            {
                MessageBox.Show("lastname Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (cmbemptype.Text == "")
            {
                MessageBox.Show("Employee Type Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbgender.Text == "")
            {
                MessageBox.Show("Gender Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (cmbdisability.Text == "")
            {
                MessageBox.Show("disability Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtAge.Text == "")
            {
                MessageBox.Show("Age Field cannot be empty please ensure the date of birth is valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Marital_Status.Text == "")
            {
                MessageBox.Show("Marital Status Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Txt_NRC.Text == "      /  /")
            {
                MessageBox.Show("NRC Field cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (Int16.Parse(txtAge.Text) <= 17)
            {
                MessageBox.Show("This Employee is Under Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                SqlConnection con = new SqlConnection(Constr);
                String Add_people = "Insert_People";
                SqlCommand cmd = new SqlCommand(Add_people, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Firstname", txtFname.Text.Trim());
                cmd.Parameters.AddWithValue("@Lastname", txtLname.Text.Trim());
                cmd.Parameters.AddWithValue("@PersonType", txtemptype.Text.Trim());
                cmd.Parameters.AddWithValue("@Age", txtAge.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", cmbgender.SelectedIndex.ToString().Trim());
                cmd.Parameters.AddWithValue("@Race", cmbRace.SelectedIndex.ToString().Trim());
                cmd.Parameters.AddWithValue("@Disability", cmbdisability.Text.Trim());
                cmd.Parameters.AddWithValue("@date_of_birth", dtp_dateofbirth.Text.Trim());
                cmd.Parameters.AddWithValue("@marital_status", Marital_Status.Text.Trim());
                cmd.Parameters.AddWithValue("@NRC", Txt_NRC.Text.Trim());
                cmd.Parameters.AddWithValue("@leave_days_per_month", txtdayspermonth.Text.Trim());
                cmd.Parameters.AddWithValue("@Employment_date", dtp_employment_date.Text.Trim());
                cmd.Parameters.AddWithValue("@employeetitle", cmbemptype.Text.Trim());
                cmd.Parameters.AddWithValue("@Student_enrollmentdate", DBNull.Value);
                cmd.Parameters.AddWithValue("@student_status", DBNull.Value);
                cmd.Parameters.AddWithValue("@student_picture", new byte[0]);
                cmd.Parameters.AddWithValue("@Student_Grade", DBNull.Value);
                cmd.Parameters.AddWithValue("@class_amount", DBNull.Value);
                cmd.Parameters.AddWithValue("@class_teacher", DBNull.Value);
                cmd.Parameters.AddWithValue("@class_year", DBNull.Value);
                cmd.Parameters.AddWithValue("@Class_id", DBNull.Value);
           
               

                cmd.Parameters.AddWithValue("@student_number", DBNull.Value);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFname.Text = "";
                    txtLname.Text = "";
                    txtAge.Text = "";
                    cmbgender.Text = "";
                    cmbRace.Text = "";
                    cmbdisability.Text = "";
                    dtp_dateofbirth.Text = "";
                    Marital_Status.Text = "";
                    Txt_NRC.Text = "";
                    txtdayspermonth.Text = "";
                    dtp_employment_date.Text = "";
                    cmbemptype.Text = "";

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

        private void dtp_dateofbirth_ValueChanged(object sender, EventArgs e)
        {
            int CurrentAge = DateTime.Today.Year - dtp_dateofbirth.Value.Year;
            txtAge.Text = CurrentAge.ToString();
        }
    

    }
}

