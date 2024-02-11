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
    public partial class Room : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Room1 values(@Room_Number,@Room_type,@Available,@Room_Cost)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@Room_Number", txtRoom_Number.Text);
            cmd.Parameters.AddWithValue("@Room_type", ddlroom_typ.Text);
            cmd.Parameters.AddWithValue("@Available", ddlAvailable.Text);
            cmd.Parameters.AddWithValue("@Room_Cost", ddlcost.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been saved";
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Room1 set  Room_Number=@Room_Number,Room_type=@Room_type,Available=@Available,Room_Cost=@Room_Cost  where Room_Id = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@Room_Number", txtRoom_Number.Text);
            cmd.Parameters.AddWithValue("@Room_type", ddlroom_typ.Text);
            cmd.Parameters.AddWithValue("@Available", ddlAvailable.Text);
            cmd.Parameters.AddWithValue("@Room_Cost", ddlcost.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Update";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Room1 where Room_Id ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Delet";
            con.Close(); ;
        }
    }
}