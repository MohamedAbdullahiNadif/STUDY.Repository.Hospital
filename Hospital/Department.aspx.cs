using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Hospital
{
    public partial class Department : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Department1 values(@Dept_Name)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@Dept_Name", txtDept_Name.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Saved";
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Department1 set Dept_Name=@Dept_Name  where Dept_ID = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@Dept_Name", txtDept_Name.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Udate";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Department1 where Dept_ID  ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Deleted";
            con.Close();
        }
    }
}