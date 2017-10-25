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

namespace Mount_Netsaiacademy_School_info_sys
{
    public partial class Login : Form
    {

        String Constr = ConfigurationManager.ConnectionStrings["Mount_Netsaiacademy_School"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            string passwordHash = MD5Hash(password);

            //string password = passwordHash.To

            SqlConnection con = new SqlConnection(Constr);

            try
            {
                con.Open();

                String Logging_in = "Logging_in";
                SqlCommand cmd = new SqlCommand(Logging_in, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@passwordHash", passwordHash);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 home = new Form1();
                    home.ShowDialog();

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



    }
}
