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

namespace Mount_Netsaiacademy_School_info_sys
{


    public partial class add_subjects_race_types_person_types : Form
    {
        DataTable dt = new DataTable();

        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;

        public add_subjects_race_types_person_types()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void BtnADDsub_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text != "")
            {
                SqlConnection con = new SqlConnection(Constr);

                SqlCommand cmmd = new SqlCommand("select * from Subjects where Subject_name = '" + txtSubject.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    String Add_Subject = "Add_Subject";
                    SqlCommand cmd = new SqlCommand(Add_Subject, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Subject", txtSubject.Text.Trim());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Subject Added Successfully");

                        this.subjectsTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet2.subjects);
                        txtSubject.Text = "";
                    }

                    catch (Exception ex)
                    {

                        throw new Exception("Exception Transfer of Querry Failed" + ex.Message);
                    }

                    finally
                    {
                        con.Close();
                    }

                }

                else
                {
                    MessageBox.Show("This subject already exists!");
                }

            }

            else
            {
                MessageBox.Show("Cannot add an empty string as a subject");
            }
        }

        private void add_subjects_race_types_person_types_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet4.Tbl_person_type' table. You can move, or remove it, as needed.
            this.tbl_person_typeTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet4.Tbl_person_type);
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet3.Tbl_race' table. You can move, or remove it, as needed.
            this.tbl_raceTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet3.Tbl_race);
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet2.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet2.subjects);

            SqlConnection con = new SqlConnection(Constr);
            String pull_subject = "Subjectpull";
            SqlCommand cmd = new SqlCommand(pull_subject, con);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    comboBox1.Items.Add(rd["subject_name"].ToString());
                    comboBox2.Items.Add(rd["subject_name"].ToString());
                    comboBox3.Items.Add(rd["subject_name"].ToString());
                    comboBox4.Items.Add(rd["subject_name"].ToString());
                    comboBox5.Items.Add(rd["subject_name"].ToString());
                    comboBox6.Items.Add(rd["subject_name"].ToString());
                    comboBox7.Items.Add(rd["subject_name"].ToString());
                    comboBox8.Items.Add(rd["subject_name"].ToString());


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



            /// <summary>
            /// //////////pull class details

            SqlConnection conn = new SqlConnection(Constr);
            SqlCommand Cmd = new SqlCommand("class_Sub_grid", conn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            sub_class.DataSource = dt;
            this.sub_class.Columns["class_id"].Visible = false;
            //classgrid.DataBind();

            ///race pull


            /// </summary>


        }


        private void buttonAddRace_Click(object sender, EventArgs e)
        {
            if (textRace.Text == "")
            {
                MessageBox.Show("Cannot add an empty string as a race");
            }

            else
            {
                SqlConnection con = new SqlConnection(Constr);

                SqlCommand cmmd = new SqlCommand("select * from Tbl_race where race_type = '" + textRace.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    String Add_Race = "Add_Race";
                    SqlCommand cmd = new SqlCommand(Add_Race, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Race", textRace.Text.Trim());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Race Added Successfully");

                        this.tbl_raceTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet3.Tbl_race);
                        textRace.Text = "";
                    }

                    catch (Exception ex)
                    {

                        throw new Exception("Exception Transfer of Querry Failed" + ex.Message);
                    }

                    finally
                    {
                        con.Close();
                    }
                }

                else
                {
                    MessageBox.Show("This race already exists!");
                }
            }
        }

        private void buttonAddPersonType_Click(object sender, EventArgs e)
        {
            if (txtPersonType.Text == "")
            {
                MessageBox.Show("Cannot add an empty string as a Person type");
            }

            else
            {
                SqlConnection con = new SqlConnection(Constr);


                SqlCommand cmmd = new SqlCommand("select * from Tbl_person_type where person_type = '" + txtPersonType.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    String Add_Person_Type = "Add_Person_Type";
                    SqlCommand cmd = new SqlCommand(Add_Person_Type, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@person_type", txtPersonType.Text.Trim());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Person Type Added Successfully");

                        this.tbl_person_typeTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet4.Tbl_person_type);
                        txtPersonType.Text = "";
                    }

                    catch (Exception ex)
                    {

                        throw new Exception("Exception Transfer of Querry Failed" + ex.Message);
                    }

                    finally
                    {
                        con.Close();
                    }
                }

                else
                {
                    MessageBox.Show("This person type already exists!");
                }
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void sub_class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sub_class.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                //btnssign.Enabled = false;
                btnUpdate.Enabled = true;
                btndelete.Enabled = true;

                string id = sub_class.SelectedRows[0].Cells[0].Value + string.Empty;
                


                Txtguid.Text = id;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Txtguid.Text == "") 
            {

                MessageBox.Show("Please select the class you want to add subjects to from the grid table", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }


            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select atleast 5 subjects!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Please select atleast 4 more subjects!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (comboBox3.Text == "")
            {
                MessageBox.Show("Please select atleast 3 more subjects!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox4.Text == "")
            {
                MessageBox.Show("Please select atleast 2 more subjects!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

             /*///for testing purposes
            else if (comboBox5.Text == "")
            {
                MessageBox.Show("Please select atleast 1 more subjects!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox6.Text == "")
            {
                MessageBox.Show("Please select an optional subjects!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                */


                /*///testing purposes
            else if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Same subject has been picked multiple times please check!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Same subject has been picked multiple times please check!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox2.Text == comboBox3.Text)
            {
                MessageBox.Show("Same subject has been picked multiple times please check!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox3.Text == comboBox4.Text)
            {
                MessageBox.Show("Same subject has been picked multiple times please check!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox4.Text == comboBox5.Text)
            {
                MessageBox.Show("Same subject has been picked multiple times please check!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            else if (comboBox5.Text == comboBox6.Text)
            {
                MessageBox.Show("Same subject has been picked multiple times please check!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox6.Text == comboBox7.Text)
            {
                MessageBox.Show("Same subject has been picked multiple times please check!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            else if (comboBox7.Text == comboBox8.Text)
            {
                MessageBox.Show("Same subject has been picked multiple times please check!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                 *     * */


            else
            {
                SqlConnection con = new SqlConnection(Constr);
                String Update_class_subjects = "Update_class_Sub";
                SqlCommand cmd = new SqlCommand(Update_class_subjects, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@classiD", Txtguid.Text.Trim());
                cmd.Parameters.AddWithValue("@Sub1", comboBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Sub2", comboBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Sub3", comboBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Sub4 ", comboBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Sub5", comboBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Sub6", comboBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@Sub7", comboBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@Sub8", comboBox8.Text.Trim());
                try
                {
                    con.Open();


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subjects have been asssigned to class ", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                    comboBox6.Text = "";
                    comboBox7.Text = "";
                    comboBox8.Text = "";

                    SqlCommand Cmd = new SqlCommand("class_Sub_grid", con);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(Cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    sub_class.DataSource = dt;
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
    }

}
