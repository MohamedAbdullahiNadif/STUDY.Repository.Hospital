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
    public partial class doctor : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Doctor1 values(@Fname, @Qualifications, @Specialization, @Phone,@Email)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@Fname", txtfullname1.Text);
            cmd.Parameters.AddWithValue("@Qualifications", ddlQualifications.Text);
            cmd.Parameters.AddWithValue("@specialization", ddlSpecialization_Type.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been saved";
            con.Close();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Doctor1 set Fname=@Fname, Qualifications=@Qualifications,Specialization=@Specialization,Phone=@Phone,Email=@Email  where Doctor_ID = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@Fname", txtfullname1.Text);
            cmd.Parameters.AddWithValue("@Qualifications", ddlQualifications.Text);
            cmd.Parameters.AddWithValue("@specialization", ddlSpecialization_Type.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Update";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Doctor1 where Doctor_ID ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Delet";
            con.Close();
        }
    }
}