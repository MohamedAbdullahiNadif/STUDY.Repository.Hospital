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
    public partial class Lab_Screening : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Lab_Screening1 values( @Test_Date,@Result,@Reference_Range,@Ordered_By)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@Test_Date", txtTest_Date.Text);
            cmd.Parameters.AddWithValue("@Result", ddlResult.Text);
            cmd.Parameters.AddWithValue("@Reference_Range", ddlReference_Range.Text);
            cmd.Parameters.AddWithValue("@Ordered_By", ddlOrdered_By.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been saved";
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Lab_Screening1 set  Test_Date=@Test_Date,Result=@Result,Reference_Range=@Reference_Range,Ordered_By=@Ordered_By  where Test_ID = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@Test_Date", txtTest_Date.Text);
            cmd.Parameters.AddWithValue("@Result", ddlResult.Text);
            cmd.Parameters.AddWithValue("@Reference_Range", ddlReference_Range.Text);
            cmd.Parameters.AddWithValue("@Ordered_By", ddlOrdered_By.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Update";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Lab_Screening1 where Test_ID ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Delet";
            con.Close(); ;
        }
    }
}