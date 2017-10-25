using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mount_Netsaiacademy_School_info_sys
{
    public partial class CreateUser : Form
    {

        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;
        string username = "";

        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);

            String Pull_Employees = "Pull_Employees";
            SqlCommand cmd = new SqlCommand(Pull_Employees, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewEmployees.DataSource = dt;
            this.dataGridViewEmployees.Columns["person_id"].Visible = false;

            string Pull_Users = "Pull_Users";
            SqlCommand cmmd = new SqlCommand(Pull_Users, con);
            cmmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter daa = new SqlDataAdapter(cmmd);
            DataTable dte = new DataTable();
            daa.Fill(dte);
            dataGridViewUsers.DataSource = dte;
            this.dataGridViewUsers.Columns["person_id"].Visible = false;

            con.Close();

        }

        private void dataGridViewEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtUserName.Text = "";
            pwPass.Text = "";
            pwConfirm.Text = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveUser.Enabled = true;

            if (dataGridViewEmployees.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string PersonId = dataGridViewEmployees.SelectedRows[0].Cells[0].Value + string.Empty;
                string EmpNames = dataGridViewEmployees.SelectedRows[0].Cells[1].Value + string.Empty;
                string Title = dataGridViewEmployees.SelectedRows[0].Cells[2].Value + string.Empty;

                txtPersonId.Text = PersonId;
                txtEmpName.Text = EmpNames;
                txtEmpTitle.Text = Title;
            }

        }

        private void dataGridViewUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            username = txtUserName.Text;
            pwPass.Text = "";
            pwConfirm.Text = "";
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveUser.Enabled = false;

            if (dataGridViewUsers.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string PersonId = dataGridViewUsers.SelectedRows[0].Cells[0].Value + string.Empty;
                string UserName = dataGridViewUsers.SelectedRows[0].Cells[1].Value + string.Empty;
                string Title = dataGridViewUsers.SelectedRows[0].Cells[2].Value + string.Empty;
                string EmpName = "";

                SqlConnection con = new SqlConnection(Constr);

                con.Open();
                string sql = "select first_name + ' ' + last_name as 'Name' from TbL_People where person_id ='" + PersonId + "'";
                SqlCommand cm = new SqlCommand(sql, con);
                SqlDataReader rd = cm.ExecuteReader();
                while (rd.Read())
                {
                    EmpName = (rd["Name"].ToString());
                }
                rd.Close();

                txtPersonId.Text = PersonId;
                txtUserName.Text = UserName;
                txtEmpTitle.Text = Title;
                txtEmpName.Text = EmpName;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataTable GetSelectedRows(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.Selected) continue; // Add only Selected Rows

                for (int i = 0; i < row.Cells.Count; i++)
                    cellValues[i] = row.Cells[i].Value;

                dt.Rows.Add(cellValues);
            }

            return dt;
        }



        private void btnCpy_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(Constr);

            //DataTable dta = new DataTable();

            //try
            //{
            //    //get data from employess grid and copy to grid users

            //    foreach (DataGridViewColumn column in dataGridViewEmployees.Columns)
            //        dta.Columns.Add(column.Name);
            //    for (int i = 0; i < dataGridViewEmployees.SelectedRows.Count; i++)
            //    {
            //        dta.Rows.Add();
            //        for (int j = 0; j < dataGridViewEmployees.Columns.Count; j++)
            //        {
            //            dta.Rows[i][j] = dataGridViewEmployees.SelectedRows[i].Cells[j].Value;

            //        }
            //    }

            //    dataGridViewUsers.DataSource = dta;
            //    label5.Text = "User to be added";

            //}

            //catch(Exception ex)
            //{
            //    MessageBox.Show("Error! " + ex.Message );
            //}

            //finally
            //{
            //    con.Close();
            //}

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {

            if (txtEmpName.Text == "")
            {
                MessageBox.Show("Please select an Employee and press the arrow to add the employee as a user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEmpTitle.Text == "")
            {
                MessageBox.Show("Please select an Employee and press the arrow to add the employee as a user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter User Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (pwPass.Text == "")
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (pwConfirm.Text == "")
            {
                MessageBox.Show("Please enter password confirmation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (pwPass.Text.Trim() != pwConfirm.Text.Trim())
            {
                MessageBox.Show("Password confirmation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlConnection con = new SqlConnection(Constr);

                var password = pwPass.Text;
                var passwordHash = MD5Hash(password);

                //check if employee is already a user
                con.Open();
                string sql = "select * from Tbl_Login where person_id ='" + txtPersonId.Text.Trim() + "'";
                SqlCommand cm = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This Employees is already a user, Please add a different Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    //save to login table
                    String Add_Users = "Add_Users";
                    SqlCommand cmd = new SqlCommand(Add_Users, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@person_id", txtPersonId.Text.Trim());
                    cmd.Parameters.AddWithValue("@user_name", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@password_hash", passwordHash.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string Pull_Users = "Pull_Users";
                    SqlCommand cmmd = new SqlCommand(Pull_Users, con);
                    cmmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter daa = new SqlDataAdapter(cmmd);
                    DataTable dte = new DataTable();
                    daa.Fill(dte);
                    dataGridViewUsers.DataSource = dte;

                }

                txtUserName.Text = "";
                pwPass.Text = "";
                pwConfirm.Text = "";

                con.Close();
            }

        }

        //public static string randomString(int length)
        //{

        //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        //    Random random = new Random();
        //    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        //}

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter a username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (pwPass.Text == "")
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (pwConfirm.Text == "")
            {
                MessageBox.Show("Please enter password confirmation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (pwPass.Text.Trim() != pwConfirm.Text.Trim())
            {
                MessageBox.Show("Password confirmation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string passwordHash = MD5Hash(pwPass.Text.Trim());

                SqlConnection con = new SqlConnection(Constr);
                con.Open();

                String Update_Users = "Update_Users";
                SqlCommand cmd = new SqlCommand(Update_Users, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@person_id", txtPersonId.Text.Trim());
                cmd.Parameters.AddWithValue("@user_name", txtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@password_hash", passwordHash);
                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Updated successfully!");

                    string Pull_Users = "Pull_Users";
                    SqlCommand cmmd = new SqlCommand(Pull_Users, con);
                    cmmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter daa = new SqlDataAdapter(cmmd);
                    DataTable dte = new DataTable();
                    daa.Fill(dte);
                    dataGridViewUsers.DataSource = dte;

                    txtEmpName.Text = "";
                    txtEmpTitle.Text = "";
                    txtUserName.Text = "";
                    pwConfirm.Text = "";
                    pwPass.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Exception! " + ex.Message);
                }

                finally
                {
                    con.Close();
                }

            }

        }

        private void pwConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            con.Open();

            String Delete_User = "Delete_User";
            SqlCommand cmd = new SqlCommand(Delete_User, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@person_id", txtPersonId.Text.Trim());

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Delete Successfull successfully!");

                    string Pull_Users = "Pull_Users";
                    SqlCommand cmmd = new SqlCommand(Pull_Users, con);
                    cmmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter daa = new SqlDataAdapter(cmmd);
                    DataTable dte = new DataTable();
                    daa.Fill(dte);
                    dataGridViewUsers.DataSource = dte;

                    txtEmpName.Text = "";
                    txtEmpTitle.Text = "";
                    txtUserName.Text = "";
                    pwConfirm.Text = "";
                    pwPass.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Exception! " + ex.Message);
                }
            }

        }
    }
}
