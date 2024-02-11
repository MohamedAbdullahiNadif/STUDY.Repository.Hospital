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
    public partial class List_Lab_Results : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        public void refreshData()
        {
            string sql = "Select * from Lab_Screening1";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            GridView1.DataBind();

        }
        protected void btnsearch_Click(object sender, EventArgs e)
        {

        }
    }
}