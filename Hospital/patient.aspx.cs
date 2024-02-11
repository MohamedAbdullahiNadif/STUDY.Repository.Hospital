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
    public partial class patient : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA;initial catalog=HMS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into Patient1 values(@Patient_FName, @Patient_LName, @Phone, @Blood_Type,@Email,@Gender,@Condition_,@Admission_Date,@Discharge_Date)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@Patient_FName", txtfname.Text);
            cmd.Parameters.AddWithValue("@Patient_LName", txtfname.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Blood_Type", ddlblood.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Gender", ddlgender.Text);
            cmd.Parameters.AddWithValue("@Condition_", txtcondition.Text);
            cmd.Parameters.AddWithValue("@Admission_Date", txtaddate.Text);
            cmd.Parameters.AddWithValue("@Discharge_Date", txtdischargedate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been saved";
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Patient1 set  Patient_FName=@Patient_FName,  Patient_LName=@Patient_LName,  Phone=@Phone,  Blood_Type=@Blood_Type, Email=@Email,  Gender=@Gender,Condition_=@Condition_,  Admission_Date=@Admission_Date, Discharge_Date=@Discharge_Date where Patient_ID = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@Patient_FName", txtfname.Text);
            cmd.Parameters.AddWithValue("@Patient_LName", txtfname.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Blood_Type", ddlblood.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Gender", ddlgender.Text);
            cmd.Parameters.AddWithValue("@Condition_", txtcondition.Text);
            cmd.Parameters.AddWithValue("@Admission_Date", txtaddate.Text);
            cmd.Parameters.AddWithValue("@Discharge_Date", txtdischargedate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Updated";
            con.Close();
        }

        protected void btnDelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from Patient1 where Patient_ID ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Your data has been Deleted";
            con.Close();
        }
    }
}