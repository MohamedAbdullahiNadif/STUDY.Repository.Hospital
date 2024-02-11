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
    public partial class Appointment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Appointment values(@Date,@Time)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@Date", txtdate.Text);
            cmd.Parameters.AddWithValue("@Time", txttime.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Saved";
            con.Close();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Appointment set  Date=@Date,Time=@Time where Appt_Id = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@Date", txtdate.Text);
            cmd.Parameters.AddWithValue("@Time", txttime.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Update";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Appointment where Appt_Id ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Delet";
            con.Close();
        }
    }
}