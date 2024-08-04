using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace new1
{
    public partial class new1 : System.Web.UI.Page
    {
        string str = ConfigurationManager.ConnectionStrings["my_db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gv_stud();
                SqlConnection con=new SqlConnection(str);
                con.Open();
                SqlCommand cmd = new SqlCommand("register_crud1");
                cmd.Parameters.AddWithValue("@action", "dd_dept");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                ddl_dept.DataSource = cmd.ExecuteReader();
                ddl_dept.DataTextField = "dept_name";
                ddl_dept.DataValueField = "dept_id";
                ddl_dept.DataBind();
                con.Close();
            }
        }
        public void gv_stud()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("register_crud1");
            cmd.Parameters.AddWithValue("@action", "SELECT");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            DataSet dt = new DataSet();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }
        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string email = txt_email.Text;
            string pass = txt_pass.Text;
            string dept = ddl_dept.SelectedValue;
            string course = ddl_course.SelectedValue;
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("register_crud1", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "INSERT");
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@dept", dept);
                    cmd.Parameters.AddWithValue("@course", course);
                    con.Open();
                    cmd.Connection=con; 
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("registerd");
                    }
                    con.Close();
                }
            }

        }
       
        protected void ddl_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("register_crud1", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "dd_course");
                    cmd.Parameters.AddWithValue("@dept_id", ddl_dept.SelectedValue);
                    con.Open();
                    ddl_course.DataSource = cmd.ExecuteReader();
                    ddl_course.DataTextField = "course_name";
                    ddl_course.DataValueField = "course_id";
                    ddl_course.DataBind();
                    con.Close();
                }
            }

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}