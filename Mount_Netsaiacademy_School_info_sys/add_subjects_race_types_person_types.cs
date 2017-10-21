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
            SqlConnection con = new SqlConnection(Constr);
            String Add_Subject = "Add_Subject";
            SqlCommand cmd = new SqlCommand(Add_Subject,con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Subject", txtSubject.Text.Trim());
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Subject Added Successfully");

                this.subjectsTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet2.subjects);
                txtSubject.Text="";
                
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

        private void add_subjects_race_types_person_types_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet4.Tbl_person_type' table. You can move, or remove it, as needed.
            this.tbl_person_typeTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet4.Tbl_person_type);
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet3.Tbl_race' table. You can move, or remove it, as needed.
            this.tbl_raceTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet3.Tbl_race);
            // TODO: This line of code loads data into the 'mount_NetsaiAcadamyDataSet2.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.mount_NetsaiAcadamyDataSet2.subjects);

        }

        private void buttonAddRace_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
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

                throw new Exception("Execption Transfer of Querry Failed" + ex.Message);


            }

            finally
            {
                con.Close();
            }
        }

        private void buttonAddPersonType_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
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

                throw new Exception("Execption Transfer of Querry Failed" + ex.Message);


            }

            finally
            {
                con.Close();
            }

        }
    }
    }


