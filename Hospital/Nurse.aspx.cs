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
    public partial class Nurse : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Nurse11 values(@F_name,@L_name,@Phone,@Gender,@Email)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@F_name", txtfullname.Text);
            cmd.Parameters.AddWithValue("@L_name", txtlast.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Gender", ddlGender.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been saved";
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Nurse11 set F_name=@F_name,L_name=@L_name,Phone=@Phone,Gender=@Gender,Email=@Email  where Nurse_ID = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@F_name", txtfullname.Text);
            cmd.Parameters.AddWithValue("@L_name", txtlast.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Gender", ddlGender.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Update";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Nurse11 where Nurse_ID ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Delet";
            con.Close(); ;

        }
    }
}