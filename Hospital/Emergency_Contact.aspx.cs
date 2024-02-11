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
    public partial class Emergency_Contact : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Emergency_Contact values(@Contact_Name,@Phone,@Relation)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@Contact_Name", txtContact_Name.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Relation", txtRelation.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Saved";
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Emergency_Contact set Contact_Name=@Contact_Name,Phone=@Phone,Relation=@Relation  where Contact_ID = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@Contact_Name", txtContact_Name.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Relation", txtRelation.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Update";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Emergency_Contact where Contact_ID ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Delet";
            con.Close(); ;

        }
    }
}