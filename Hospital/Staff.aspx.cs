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
    public partial class Staff : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Staff13 values(@Staff_FName,@Staff_LName,@Date_Joining,@Specialization_Type,@Email,@Address)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@Staff_FName", txtStaff_FName.Text);
            cmd.Parameters.AddWithValue("@Staff_LName", txtStaff_LName.Text);
            cmd.Parameters.AddWithValue("@Date_Joining", txtDate_Joining.Text);
            cmd.Parameters.AddWithValue("@Specialization_Type", ddlSpecialization_Type.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Address", ddlAddress.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been saved";
            con.Close();
        }

        protected void btnUdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Staff13 set Staff_FName=@Staff_FName,Staff_LName=@Staff_LName,Date_Joining=@Date_Joining,Specialization_Type=@Specialization_Type,Email=@Email,Address=@Address where staff_ID = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@Staff_FName", txtStaff_FName.Text);
            cmd.Parameters.AddWithValue("@Staff_LName", txtStaff_LName.Text);
            cmd.Parameters.AddWithValue("@Date_Joining", txtDate_Joining.Text);
            cmd.Parameters.AddWithValue("@Specialization_Type", ddlSpecialization_Type.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Address", ddlAddress.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Update";
            con.Close();

        }

        protected void btndate_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Staff13 where staff_ID ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Delet";
            con.Close();

        }
    }
}