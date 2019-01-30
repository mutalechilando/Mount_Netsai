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
using System.Security.Cryptography;
using System.Globalization;
namespace Mount_Netsaiacademy_School_info_sys
{
    public partial class Login : Form
    {
       
        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;
        public static string userName;
        public static string type;
        public static string position;
        
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtUserName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string title = txtemptitle.Text;
            string passwordHash = MD5Hash(password);

            //string password = passwordHash.To

            SqlConnection con = new SqlConnection(Constr);
            con.Open();

            String Logging_in = "Logging_in";
            SqlCommand cmd = new SqlCommand(Logging_in, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@passwordHash", passwordHash);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                

                if (dt.Rows.Count > 0)
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    
                    

                    if (rd.Read())
                    {
                        txtemptitle.Text = rd["emp_title"].ToString();
                        txtfullnames.Text = rd["fullnames"].ToString();
                        type = txtfullnames.Text;
                        position = txtemptitle.Text;
                        var emp_title = rd["emp_title"].ToString();

                        if (emp_title.Equals("Manager"))
                        {
                            MessageBox.Show("welcome '" + txtemptitle.Text + "'","Succes", MessageBoxButtons.OK,MessageBoxIcon.Information);
                           
                            this.Hide();
                            dashboard home = new dashboard();
                            home.manageStudentToolStripMenuItem.Visible = false;
                            home.ShowDialog();
                        }
                        else if (emp_title.Equals("Principal"))
                        {
                            this.Hide();
                            dashboard home = new dashboard();
                            home.manageStudentToolStripMenuItem.Visible = false;
                            home.ShowDialog();
                            //dashboard.manageStudentToolStripMenuItem.Visible = False;
                        }
                        else if (emp_title.Equals("Teacher"))
                        {
                            this.Hide();
                            dashboard home = new dashboard();
                            home.manageStudentToolStripMenuItem.Visible = false;
                            home.ShowDialog();
                            //dashboard.manageStudentToolStripMenuItem.Visible = False;
                        }
                        else if (emp_title.Equals("Administrator"))
                        {
                            this.Hide();
                            dashboard home = new dashboard();
                            home.manageStudentToolStripMenuItem.Visible = true;
                            home.ShowDialog();
                            //dashboard.manageStudentToolStripMenuItem.Visible = False;
                        }
                       

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                    pictureLock.Visible = true;
                }
            }
            finally
            {
                con.Close();
            }

        }
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

        public void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



    }
}
