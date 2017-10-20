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
         
        }
    }


