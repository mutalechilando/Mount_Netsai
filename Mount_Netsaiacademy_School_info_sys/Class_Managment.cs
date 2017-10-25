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
    public partial class Class_Managment : Form
    {
        DataTable dt = new DataTable();
        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;

        public Class_Managment()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Class_Managment_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Constr);
            SqlCommand Cmd = new SqlCommand("class_grid", conn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            classgrid.DataSource = dt;
            this.classgrid.Columns["class_id"].Visible = false;
            //classgrid.DataBind();

            ///race pull
            SqlConnection con = new SqlConnection(Constr);
            String pullemp = "pull_emp";
            SqlCommand cmd = new SqlCommand(pullemp, con);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    cmbteacher.Items.Add(rd["Name"].ToString());


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
                cmbyear.Items.Add(i.ToString());// pseudo
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbgrade.Text == "Nursery")
            {

                txtSuffix.Enabled = false;

            }

            else if (cmbgrade.Text == "Reception")
            {
                txtSuffix.Enabled = false;

            }
            else
            {

                txtSuffix.Enabled = true;

            }
        }

        private void cmbteacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            String Assign_class = "assign_class";
            SqlCommand cmd = new SqlCommand(Assign_class, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@grade", cmbgrade.Text.Trim());
            cmd.Parameters.AddWithValue("@class_year", cmbyear.Text.Trim());
            cmd.Parameters.AddWithValue("@suffix ", txtSuffix.Text.Trim());
            cmd.Parameters.AddWithValue("@amount", txtamount.Text.Trim());
            cmd.Parameters.AddWithValue("@classTeacher", cmbteacher.Text.Trim());



            try
            {
                con.Open();


                cmd.ExecuteNonQuery();
                MessageBox.Show("Mr / mrs '" + cmbteacher.Text + "'has been Assigned to class '" + cmbgrade.Text + "' '" + txtSuffix.Text + "' Year '" + cmbyear.Text + "' Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbgrade.Text = "";
                cmbyear.Text = "";
                txtSuffix.Text = "";
                txtamount.Text = "";
                cmbteacher.Text = "";
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

        private void classgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (classgrid.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string id = classgrid.SelectedRows[0].Cells[0].Value + string.Empty;
                string grade = classgrid.SelectedRows[0].Cells[2].Value + string.Empty;
                string year = classgrid.SelectedRows[0].Cells[1].Value + string.Empty;
                string amount_fee = classgrid.SelectedRows[0].Cells[4].Value + string.Empty;
                string suffix = classgrid.SelectedRows[0].Cells[5].Value + string.Empty;


                cmbyear.Text = year;
                cmbgrade.Text = grade;
                txtamount.Text = amount_fee;
                txtSuffix.Text = suffix;
                txtclass_id.Text = id;
            }

        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            String Update_class = "Update_class";
            SqlCommand cmd = new SqlCommand(Update_class, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classiD", txtclass_id.Text.Trim());
            cmd.Parameters.AddWithValue("@grade", cmbgrade.Text.Trim());
            cmd.Parameters.AddWithValue("@class_year", cmbyear.Text.Trim());
            cmd.Parameters.AddWithValue("@suffix ", txtSuffix.Text.Trim());
            cmd.Parameters.AddWithValue("@amount", txtamount.Text.Trim());
            cmd.Parameters.AddWithValue("@classTeacher", cmbteacher.Text.Trim());
            try
            {
                con.Open();


                cmd.ExecuteNonQuery();
                MessageBox.Show("Mr / mrs '" + cmbteacher.Text + "'has been Re-Assigned to class '" + cmbgrade.Text + "' '" + txtSuffix.Text + "' Year '" + cmbyear.Text + "' Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbgrade.Text = "";
                cmbyear.Text = "";
                txtSuffix.Text = "";
                txtamount.Text = "";
                cmbteacher.Text = "";
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            String Deletec_class = "Delete_class ";
            SqlCommand cmd = new SqlCommand(Deletec_class, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@class_id", txtclass_id.Text.Trim());     
            try
            {
                con.Open();


                cmd.ExecuteNonQuery();
                MessageBox.Show("Mr / mrs '" + cmbteacher.Text + "'has been Deleted from class '" + cmbgrade.Text + "' '" + txtSuffix.Text + "' Year '" + cmbyear.Text + "' Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbgrade.Text = "";
                cmbyear.Text = "";
                txtSuffix.Text = "";
                txtamount.Text = "";
                cmbteacher.Text = "";

                SqlConnection conn = new SqlConnection(Constr);
                SqlCommand Cmd = new SqlCommand("class_grid", conn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                da.Fill(dt);
                classgrid.DataSource = dt;
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
