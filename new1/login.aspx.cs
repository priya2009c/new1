using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace new1
{
    public partial class login : System.Web.UI.Page
    {
        string str = ConfigurationManager.ConnectionStrings["my_db"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string pass = txt_pass.Text;
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("register_crud1", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "LOGIN");
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    con.Open();
                    int res =(int)cmd.ExecuteScalar();
                    if (res > 0)
                    {
                        // Login successful, handle accordingly
                        System.Windows.Forms.MessageBox.Show("Logged In");

                    }
                    else
                    {
                        // Login failed, handle accordingly
                        System.Windows.Forms.MessageBox.Show("Invalid Credentials");
                    }
                    con.Close();
                }
            }
        }
    }
}