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
    public partial class Medicine : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Medicine values(@M_Name,@Date)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@M_Name", txtM_Name.Text);
            cmd.Parameters.AddWithValue("@Date", txtdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Saved";
            con.Close();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Medicine set  M_Name=@M_Name,Date=@Date where Medicine_Id = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@M_Name", txtM_Name.Text);
            cmd.Parameters.AddWithValue("@Date", txtdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Update";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Medicine where Medicine_Id ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Delet";
            con.Close();
        }
    }
}