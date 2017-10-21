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

            SqlConnection con = new SqlConnection(Constr);

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select user_name, password_hash from Tbl_Login where user_name = '" + userName + "' and password_hash = '" + password + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful");
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
    }
}
